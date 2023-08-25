
namespace Jbig2Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertPagesBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertPagesAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.saveJbig2FileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openJbig2FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageLoadingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageLoadingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imagesEncodingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagesEncodingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageEncodingProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageEncodingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewerToolStrip = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(794, 24);
            this.mainMenu.TabIndex = 12;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newFileToolStripMenuItem.Text = "New";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openFileToolStripMenuItem.Text = "Open...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveFileToolStripMenuItem.Text = "Save";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveFileAsToolStripMenuItem.Text = "Save As...";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerImageToolStripMenuItem,
            this.imageViewerSettingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.CheckOnClick = true;
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.centerImageToolStripMenuItem.Text = "Center Image";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPagesToolStripMenuItem,
            this.insertPagesBeforeToolStripMenuItem,
            this.insertPagesAfterToolStripMenuItem,
            this.removePageToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // addPagesToolStripMenuItem
            // 
            this.addPagesToolStripMenuItem.Name = "addPagesToolStripMenuItem";
            this.addPagesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addPagesToolStripMenuItem.Text = "Add Pages...";
            this.addPagesToolStripMenuItem.Click += new System.EventHandler(this.addPagesButton_Click);
            // 
            // insertPagesBeforeToolStripMenuItem
            // 
            this.insertPagesBeforeToolStripMenuItem.Name = "insertPagesBeforeToolStripMenuItem";
            this.insertPagesBeforeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertPagesBeforeToolStripMenuItem.Text = "Insert Pages Before...";
            this.insertPagesBeforeToolStripMenuItem.Click += new System.EventHandler(this.insertPagesBeforeToolStripMenuItem_Click);
            // 
            // insertPagesAfterToolStripMenuItem
            // 
            this.insertPagesAfterToolStripMenuItem.Name = "insertPagesAfterToolStripMenuItem";
            this.insertPagesAfterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insertPagesAfterToolStripMenuItem.Text = "Insert Pages After...";
            this.insertPagesAfterToolStripMenuItem.Click += new System.EventHandler(this.insertPagesAfterToolStripMenuItem_Click);
            // 
            // removePageToolStripMenuItem
            // 
            this.removePageToolStripMenuItem.Enabled = false;
            this.removePageToolStripMenuItem.Name = "removePageToolStripMenuItem";
            this.removePageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removePageToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.removePageToolStripMenuItem.Text = "Remove Current Page";
            this.removePageToolStripMenuItem.Click += new System.EventHandler(this.removePageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openAllFilesDialog
            // 
            this.openAllFilesDialog.Filter = resources.GetString("openAllFilesDialog.Filter");
            this.openAllFilesDialog.FilterIndex = 9;
            this.openAllFilesDialog.Multiselect = true;
            // 
            // imageViewer1
            // 
            this.imageViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageViewer1.AutoScroll = true;
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageViewer1.Location = new System.Drawing.Point(12, 59);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(770, 480);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.PixelToPixel;
            this.imageViewer1.TabIndex = 14;
            this.imageViewer1.Text = "imageViewer1";
            // 
            // saveJbig2FileDialog
            // 
            this.saveJbig2FileDialog.DefaultExt = "jb2";
            this.saveJbig2FileDialog.Filter = "JBIG2 Files|*.jb2; *.Jbig2";
            // 
            // openJbig2FileDialog
            // 
            this.openJbig2FileDialog.Filter = "JBIG2 Files|*.jb2;*.Jbig2;";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageLoadingProgressBarLabel,
            this.imageLoadingProgressBar,
            this.imagesEncodingProgressBarLabel,
            this.imagesEncodingProgressBar,
            this.imageEncodingProgressBarLabel,
            this.imageEncodingProgressBar,
            this.imageInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageLoadingProgressBarLabel
            // 
            this.imageLoadingProgressBarLabel.Name = "imageLoadingProgressBarLabel";
            this.imageLoadingProgressBarLabel.Size = new System.Drawing.Size(82, 17);
            this.imageLoadingProgressBarLabel.Text = "Loading page:";
            this.imageLoadingProgressBarLabel.Visible = false;
            // 
            // imageLoadingProgressBar
            // 
            this.imageLoadingProgressBar.Name = "imageLoadingProgressBar";
            this.imageLoadingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageLoadingProgressBar.Visible = false;
            // 
            // imagesEncodingProgressBarLabel
            // 
            this.imagesEncodingProgressBarLabel.Name = "imagesEncodingProgressBarLabel";
            this.imagesEncodingProgressBarLabel.Size = new System.Drawing.Size(101, 17);
            this.imagesEncodingProgressBarLabel.Text = "Encoding images:";
            this.imagesEncodingProgressBarLabel.Visible = false;
            // 
            // imagesEncodingProgressBar
            // 
            this.imagesEncodingProgressBar.Name = "imagesEncodingProgressBar";
            this.imagesEncodingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imagesEncodingProgressBar.Visible = false;
            // 
            // imageEncodingProgressBarLabel
            // 
            this.imageEncodingProgressBarLabel.Name = "imageEncodingProgressBarLabel";
            this.imageEncodingProgressBarLabel.Size = new System.Drawing.Size(96, 17);
            this.imageEncodingProgressBarLabel.Text = "Encoding image:";
            this.imageEncodingProgressBarLabel.Visible = false;
            // 
            // imageEncodingProgressBar
            // 
            this.imageEncodingProgressBar.Name = "imageEncodingProgressBar";
            this.imageEncodingProgressBar.Size = new System.Drawing.Size(100, 16);
            this.imageEncodingProgressBar.Visible = false;
            // 
            // imageInfoLabel
            // 
            this.imageInfoLabel.Name = "imageInfoLabel";
            this.imageInfoLabel.Size = new System.Drawing.Size(779, 17);
            this.imageInfoLabel.Spring = true;
            this.imageInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewerToolStrip
            // 
            this.viewerToolStrip.AssociatedZoomTrackBar = null;
            this.viewerToolStrip.CanPrint = false;
            this.viewerToolStrip.ImageViewer = this.imageViewer1;
            this.viewerToolStrip.ScanButtonEnabled = true;
            this.viewerToolStrip.Location = new System.Drawing.Point(0, 24);
            this.viewerToolStrip.Name = "viewerToolStrip";
            this.viewerToolStrip.PageCount = 0;
            this.viewerToolStrip.PrintButtonEnabled = true;
            this.viewerToolStrip.SaveButtonEnabled = true;
            this.viewerToolStrip.Size = new System.Drawing.Size(794, 25);
            this.viewerToolStrip.TabIndex = 0;
            this.viewerToolStrip.Text = "vsImageViewerToolStrip";
            this.viewerToolStrip.UseImageViewerImages = false;
            this.viewerToolStrip.OpenFile += new System.EventHandler(this.openFileButton_Click);
            this.viewerToolStrip.SaveFile += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.viewerToolStrip.PageIndexChanged += new System.EventHandler<DemosCommonCode.Imaging.PageIndexChangedEventArgs>(this.imageViewerToolStrip_PageIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 574);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imageViewer1);
            this.Controls.Add(this.viewerToolStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(625, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VintaSoft Multipage JBIG2 Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openAllFilesDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openJbig2FileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private DemosCommonCode.Imaging.ImageViewerToolStrip viewerToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel imageLoadingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imageLoadingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoLabel;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertPagesBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertPagesAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveJbig2FileDialog;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel imagesEncodingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imagesEncodingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel imageEncodingProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar imageEncodingProgressBar;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}
