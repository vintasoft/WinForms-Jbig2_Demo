using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Jbig2;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.Utils;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;
using DemosCommonCode.Imaging.Codecs.Dialogs;


namespace Jbig2Demo
{
    /// <summary>
    /// Main form of JBIG2 Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Template of application title.
        /// </summary>
        string _titlePrefix = string.Format("VintaSoft Multipage JBIG2 Demo v{0}", ImagingGlobalSettings.ProductVersion);

        /// <summary>
        /// JBIG2 file object that manipulates JBIG2 file.
        /// </summary>
        Jbig2File _jbig2File;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            imageViewer1.RenderingQuality = ImageRenderingQuality.High;

            // create new JBIG2 file in memory
            _jbig2File = new Jbig2File();

            // update the application title after JBIG2 file is loaded/closed
            UpdateApplicationTitle(null);

            this.FormClosing += new FormClosingEventHandler(mainForm_FormClosing);

            // set the initial directory in open dialog
            DemosTools.SetTestFilesFolder(openJbig2FileDialog);
            DemosTools.SetTestFilesFolder(openAllFilesDialog);

            // set filters in open dialog
            CodecsFileFilters.SetOpenFileDialogFilter(openAllFilesDialog);

            UpdateUI();
        }

        #endregion



        #region Properties

        bool _isJbig2FileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether JBIG2 file is opening.
        /// </summary>
        internal bool IsJbig2FileOpening
        {
            get
            {
                return _isJbig2FileOpening;
            }
            set
            {
                _isJbig2FileOpening = value;
                UpdateUI();
            }
        }

        bool _isJbig2FileLocked = false;
        /// <summary>
        /// Gets or sets a value indicating whether JBIG2 file is locked (image loading,
        /// image adding, file saving, file packing, etc).
        /// </summary>
        internal bool IsJbig2FileLocked
        {
            get
            {
                return _isJbig2FileLocked;
            }
            set
            {
                _isJbig2FileLocked = value;
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of NewFileButton object.
        /// </summary>
        private void newFileButton_Click(object sender, EventArgs e)
        {
            IsJbig2FileOpening = true;

            // close current JBIG2 file if necessary
            CloseFile();

            // create new JBIG2 file in memory
            _jbig2File = new Jbig2File();

            // update application title after JBIG2 file is loaded/closed
            UpdateApplicationTitle(null);
            // update page count after JBIG2 file is loaded/changed
            UpdatePageCount();

            IsJbig2FileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of OpenFileButton object.
        /// </summary>
        private void openFileButton_Click(object sender, EventArgs e)
        {
            IsJbig2FileOpening = true;

            if (openJbig2FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // close the current JBIG2 file if necessary
                CloseFile();

                try
                {
                    // open new JBIG2 file
                    _jbig2File = new Jbig2File(openJbig2FileDialog.FileName);

                    // update application title after JBIG2 file is loaded/closed
                    UpdateApplicationTitle(openJbig2FileDialog.FileName);
                }
                catch (Exception ex)
                {
                    _jbig2File = null;

                    // update application title after JBIG2 file is loaded/closed
                    UpdateApplicationTitle(null);

                    DemosTools.ShowErrorMessage("File load error", ex);
                }
                finally
                {
                    // update page count after JBIG2 file is loaded/changed
                    UpdatePageCount();

                    SetCurrentPageIndex(0, true);
                }
            }

            IsJbig2FileOpening = false;
        }

        /// <summary>
        /// Handles the Click event of SaveToolStripMenuItem object.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsJbig2FileLocked = true;

            // create progress controller
            IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

            // save changes in the current JBIG2 file
            _jbig2File.SaveChanges(progressController);

            IsJbig2FileLocked = false;
        }

        /// <summary>
        /// Handles the Click event of SaveAsToolStripMenuItem object.
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsJbig2FileLocked = true;

            if (saveJbig2FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // create progress controller
                    IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

                    // save changes to new JBIG2 file and switch to it
                    _jbig2File.SaveChanges(saveJbig2FileDialog.FileName, progressController);

                    // update the application title after JBIG2 file is saved
                    UpdateApplicationTitle(saveJbig2FileDialog.FileName);
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }

            IsJbig2FileLocked = false;
        }

        /// <summary>
        /// Handles the Click event of CloseToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current JBIG2 file
            CloseFile();

            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of ExitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of CenterImageToolStripMenuItem object.
        /// </summary>
        private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centerImageToolStripMenuItem.Checked)
            {
                // enable image centering in image viewer
                imageViewer1.FocusPointAnchor = AnchorType.None;
                imageViewer1.IsFocusPointFixed = true;
                imageViewer1.ScrollToCenter();
            }
            else
            {
                // disable image centering in image viewer
                imageViewer1.FocusPointAnchor = AnchorType.Left | AnchorType.Top;
                imageViewer1.IsFocusPointFixed = true;
            }
        }

        /// <summary>
        /// Handles the Click event of ImageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageViewerSettingsForm viewerSettingsDialog = new ImageViewerSettingsForm(imageViewer1);
            viewerSettingsDialog.CanEditMultipageSettings = false;
            viewerSettingsDialog.ShowDialog();
        }

        #endregion


        #region 'Page' menu

        /// <summary>
        /// Handles the Click event of AddPagesButton object.
        /// </summary>
        private void addPagesButton_Click(object sender, EventArgs e)
        {
            // add pages to the end of file
            InsertPages(_jbig2File.Pages.Count);
        }

        /// <summary>
        /// Handles the Click event of InsertPagesBeforeToolStripMenuItem object.
        /// </summary>
        private void insertPagesBeforeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pageIndex = viewerToolStrip.SelectedPageIndex;

            // insert pages before current page
            InsertPages(pageIndex);
        }

        /// <summary>
        /// Handles the Click event of InsertPagesAfterToolStripMenuItem object.
        /// </summary>
        private void insertPagesAfterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pageIndex = 0;
            if (_jbig2File.Pages.Count > 0)
            {
                pageIndex = viewerToolStrip.SelectedPageIndex + 1;
            }

            // insert pages after current page
            InsertPages(pageIndex);
        }

        /// <summary>
        /// Handles the Click event of RemovePageToolStripMenuItem object.
        /// </summary>
        private void removePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int pageIndex = viewerToolStrip.SelectedPageIndex;

                // remove selected page
                _jbig2File.Pages.RemoveAt(pageIndex);

                // update page count after JBIG2 file is changed
                UpdatePageCount();

                if (pageIndex >= _jbig2File.Pages.Count)
                    viewerToolStrip.SelectedPageIndex--;
                else
                    SetCurrentPageIndex(pageIndex, true);

                // update the UI
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of AboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        /// <summary>
        /// Handles the PageIndexChanged event of ImageViewerToolStrip object.
        /// </summary>
        private void imageViewerToolStrip_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            SetCurrentPageIndex(e.SelectedPageIndex, false);
        }

        /// <summary>
        /// Handles the FormClosing event of MainForm object.
        /// </summary>
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFile();
        }

        #endregion


        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            if (IsJbig2FileLocked)
                Cursor = Cursors.WaitCursor;
            else
                Cursor = Cursors.Default;

            // get the current status of application
            bool isJbig2FileOpening = IsJbig2FileOpening;
            bool isJbig2FileLoaded = _jbig2File != null;
            bool isJbig2FileEmpty = true;
            if (isJbig2FileLoaded)
                isJbig2FileEmpty = _jbig2File.Pages.Count <= 0;
            bool isJbig2FileLocked = IsJbig2FileLocked;

            // "File" menu
            newFileToolStripMenuItem.Enabled = !isJbig2FileOpening && !isJbig2FileLocked;
            openFileToolStripMenuItem.Enabled = !isJbig2FileOpening && !isJbig2FileLocked;
            saveFileToolStripMenuItem.Enabled = !isJbig2FileOpening && isJbig2FileLoaded &&
                                                !isJbig2FileEmpty && !isJbig2FileLocked;
            saveFileAsToolStripMenuItem.Enabled = !isJbig2FileOpening && isJbig2FileLoaded &&
                                                  !isJbig2FileEmpty && !isJbig2FileLocked;

            // "Page" menu
            pageToolStripMenuItem.Enabled = !isJbig2FileOpening && isJbig2FileLoaded && !isJbig2FileLocked;
            removePageToolStripMenuItem.Enabled = !isJbig2FileOpening && !isJbig2FileEmpty && !isJbig2FileLocked;

            // ViewerToolStrip
            viewerToolStrip.Enabled = !isJbig2FileOpening && !isJbig2FileLocked;
            viewerToolStrip.SaveButtonEnabled = isJbig2FileLoaded && !isJbig2FileEmpty;
        }

        /// <summary>
        /// Updates the application title after JBIG2 file is created/loaded/saved/closed.
        /// </summary>
        private void UpdateApplicationTitle(string filename)
        {
            if (_jbig2File != null)
            {
                if (filename == null)
                    filename = "(Untitled)";
                this.Text = string.Format("{0} - {1}", _titlePrefix, filename);
            }
            else
            {
                this.Text = _titlePrefix;
            }
        }

        /// <summary>
        /// Updates the page count after JBIG2 file is created/loaded/changed.
        /// </summary>
        private void UpdatePageCount()
        {
            int pageCount = 0;
            if (_jbig2File != null)
                pageCount = _jbig2File.Pages.Count;

            viewerToolStrip.PageCount = pageCount;
        }

        /// <summary>
        /// Closes opened JBIG2 file.
        /// </summary>
        private void CloseFile()
        {
            if (_jbig2File != null)
            {
                imageViewer1.Images.ClearAndDisposeItems();

                _jbig2File.Dispose();
                _jbig2File = null;

                // update application title after JBIG2 file is closed
                UpdateApplicationTitle(null);
                // update page count after JBIG2 file is closed
                UpdatePageCount();

                imageInfoLabel.Text = "";
            }
        }

        /// <summary>
        /// Sets the specified page as the current page.
        /// </summary>
        /// <param name="newIndex">New page index.</param>
        /// <param name="setInToolStrip">Indicates whether to update page index in the viewer tool strip.</param>
        private void SetCurrentPageIndex(int newIndex, bool setInToolStrip)
        {
            IsJbig2FileLocked = true;

            try
            {
                VintasoftImage previousImage = imageViewer1.Image;

                if (newIndex >= 0 && _jbig2File != null)
                {
                    // get reference to current JBIG2 page
                    Jbig2Page currentPage = _jbig2File.Pages[newIndex];

                    // show information about current image
                    imageInfoLabel.Text = string.Format("Width={0}; Height={1}; Resolution={2}; BitsPerPixel={3}",
                        currentPage.Width, currentPage.Height, currentPage.Resolution, currentPage.BitsPerPixel);

                    // set current image as focused image in image viewer
                    imageViewer1.Image = currentPage.GetImage(ImageLoadingProgress);
                }
                else
                {
                    imageInfoLabel.Text = "";

                    imageViewer1.Image = null;
                }

                if (previousImage != null)
                    previousImage.Dispose();
            }
            catch (DecoderException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Demo version restrictions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (setInToolStrip)
            {
                if (viewerToolStrip.SelectedPageIndex != newIndex)
                {
                    viewerToolStrip.SelectedPageIndex = newIndex;
                }
            }

            IsJbig2FileLocked = false;
        }

        /// <summary>
        /// Inserts pages starting at the specified index.
        /// </summary>
        /// <param name="pageIndex">Index at which pages are inserted.</param>
        private void InsertPages(int pageIndex)
        {
            IsJbig2FileLocked = true;

            if (openAllFilesDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    // create image collection to add multiple pages
                    ImageCollection imageCollection = new ImageCollection();
                    DocumentPasswordForm.EnableAuthentication(imageCollection);
                    try
                    {
                        foreach (string filename in openAllFilesDialog.FileNames)
                        {
                            imageCollection.Add(filename);
                        }

                        // show a form that allows to specify encoder settings
                        using (Jbig2EncoderSettingsForm jbig2EncoderSettingsDlg = new Jbig2EncoderSettingsForm())
                        {
                            jbig2EncoderSettingsDlg.StartPosition = FormStartPosition.CenterScreen;
                            jbig2EncoderSettingsDlg.AppendExistingDocumentEnabled = false;
                            jbig2EncoderSettingsDlg.EncoderSettings = _jbig2File.Pages.EncoderSettings;
                            if (jbig2EncoderSettingsDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                IProgressController progressController = new ProgressControllerWithDelegates(ImagesEncodingProgress, ImageEncodingProgress);

                                // if pages are added to the end of file
                                if (pageIndex == _jbig2File.Pages.Count)
                                {
                                    // add pages
                                    _jbig2File.Pages.Add(imageCollection, progressController);
                                }
                                else
                                {
                                    // insert pages starting at the specified index
                                    _jbig2File.Pages.Insert(pageIndex, imageCollection, progressController);
                                }
                            }
                        }

                        imageCollection.ClearAndDisposeItems();
                    }
                    finally
                    {
                        DocumentPasswordForm.DisableAuthentication(imageCollection);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pageIndex = viewerToolStrip.SelectedPageIndex;
                }
                finally
                {
                    // update page count after JBIG2 file is changed
                    UpdatePageCount();

                    SetCurrentPageIndex(pageIndex, true);
                }
            }

            IsJbig2FileLocked = false;
        }

        /// <summary>
        /// The callback method for image loading progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImageLoadingProgress(object sender, ProgressEventArgs e)
        {
            imageLoadingProgressBarLabel.Visible = e.Progress != 100;
            imageLoadingProgressBar.Visible = e.Progress != 100;
            imageLoadingProgressBar.Value = e.Progress;

            Application.DoEvents();
        }

        /// <summary>
        /// The callback method for images encoding progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImagesEncodingProgress(object sender, ProgressEventArgs e)
        {
            imagesEncodingProgressBarLabel.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Visible = e.Progress != 100;
            imagesEncodingProgressBar.Value = e.Progress;

            Application.DoEvents();
        }

        /// <summary>
        /// The callback method for image encoding progress.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressEventArgs"/> instance containing the event data.</param>
        private void ImageEncodingProgress(object sender, ProgressEventArgs e)
        {
            imageEncodingProgressBarLabel.Visible = e.Progress != 100;
            imageEncodingProgressBar.Visible = e.Progress != 100;
            imageEncodingProgressBar.Value = e.Progress;

            Application.DoEvents();
        }

        #endregion

    }
}
