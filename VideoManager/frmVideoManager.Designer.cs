namespace VideoManager
{
    partial class frmVideoManager
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbxDirectories = new System.Windows.Forms.ListBox();
            this.lvwVideos = new System.Windows.Forms.ListView();
            this.Video = new System.Windows.Forms.ColumnHeader();
            this.btnLoadVideos = new System.Windows.Forms.Button();
            this.btnColumnDec = new System.Windows.Forms.Button();
            this.btnColumnInc = new System.Windows.Forms.Button();
            this.btnShowFileType = new System.Windows.Forms.Button();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnFindDirectories = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnFileExt = new System.Windows.Forms.Button();
            this.btnDirectoryDelete = new System.Windows.Forms.Button();
            this.btnOpenVideo = new System.Windows.Forms.Button();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.lblFileActions = new System.Windows.Forms.Label();
            this.btnCopyServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxDirectories
            // 
            this.lbxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxDirectories.FormattingEnabled = true;
            this.lbxDirectories.Location = new System.Drawing.Point(253, 492);
            this.lbxDirectories.Name = "lbxDirectories";
            this.lbxDirectories.Size = new System.Drawing.Size(227, 43);
            this.lbxDirectories.TabIndex = 4;
            // 
            // lvwVideos
            // 
            this.lvwVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwVideos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Video});
            this.lvwVideos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwVideos.ForeColor = System.Drawing.Color.Black;
            this.lvwVideos.GridLines = true;
            this.lvwVideos.HideSelection = false;
            this.lvwVideos.LabelEdit = true;
            this.lvwVideos.Location = new System.Drawing.Point(0, 0);
            this.lvwVideos.Name = "lvwVideos";
            this.lvwVideos.Size = new System.Drawing.Size(801, 484);
            this.lvwVideos.TabIndex = 0;
            this.lvwVideos.TileSize = new System.Drawing.Size(300, 100);
            this.lvwVideos.UseCompatibleStateImageBehavior = false;
            this.lvwVideos.View = System.Windows.Forms.View.List;
            this.lvwVideos.ItemActivate += new System.EventHandler(this.lvwVideos_ItemActivate);
            this.lvwVideos.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwVideos_AfterLabelEdit);
            // 
            // Video
            // 
            this.Video.Text = "Video";
            this.Video.Width = 400;
            // 
            // btnLoadVideos
            // 
            this.btnLoadVideos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadVideos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadVideos.Location = new System.Drawing.Point(2, 492);
            this.btnLoadVideos.Name = "btnLoadVideos";
            this.btnLoadVideos.Size = new System.Drawing.Size(88, 41);
            this.btnLoadVideos.TabIndex = 1;
            this.btnLoadVideos.Text = "Load";
            this.btnLoadVideos.UseVisualStyleBackColor = true;
            this.btnLoadVideos.Click += new System.EventHandler(this.btnLoadVideos_Click);
            // 
            // btnColumnDec
            // 
            this.btnColumnDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColumnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumnDec.Location = new System.Drawing.Point(739, 492);
            this.btnColumnDec.Name = "btnColumnDec";
            this.btnColumnDec.Size = new System.Drawing.Size(30, 21);
            this.btnColumnDec.TabIndex = 8;
            this.btnColumnDec.Text = "<";
            this.btnColumnDec.UseVisualStyleBackColor = true;
            this.btnColumnDec.Click += new System.EventHandler(this.btnColumnDec_Click);
            // 
            // btnColumnInc
            // 
            this.btnColumnInc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColumnInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumnInc.Location = new System.Drawing.Point(769, 492);
            this.btnColumnInc.Name = "btnColumnInc";
            this.btnColumnInc.Size = new System.Drawing.Size(29, 21);
            this.btnColumnInc.TabIndex = 9;
            this.btnColumnInc.Text = ">";
            this.btnColumnInc.UseVisualStyleBackColor = true;
            this.btnColumnInc.Click += new System.EventHandler(this.btnColumnInc_Click);
            // 
            // btnShowFileType
            // 
            this.btnShowFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFileType.Location = new System.Drawing.Point(686, 492);
            this.btnShowFileType.Name = "btnShowFileType";
            this.btnShowFileType.Size = new System.Drawing.Size(52, 21);
            this.btnShowFileType.TabIndex = 7;
            this.btnShowFileType.Text = "See";
            this.btnShowFileType.UseVisualStyleBackColor = true;
            this.btnShowFileType.Click += new System.EventHandler(this.btnShowFileType_Click);
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCopyFile.Location = new System.Drawing.Point(639, 513);
            this.btnCopyFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(46, 21);
            this.btnCopyFile.TabIndex = 10;
            this.btnCopyFile.Text = "Here";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // btnFindDirectories
            // 
            this.btnFindDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindDirectories.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDirectories.Location = new System.Drawing.Point(168, 492);
            this.btnFindDirectories.Name = "btnFindDirectories";
            this.btnFindDirectories.Size = new System.Drawing.Size(82, 41);
            this.btnFindDirectories.TabIndex = 3;
            this.btnFindDirectories.Text = "Find Dir.";
            this.btnFindDirectories.UseVisualStyleBackColor = true;
            this.btnFindDirectories.Click += new System.EventHandler(this.btnFindDirectories_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFile.Location = new System.Drawing.Point(739, 513);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(59, 21);
            this.btnDeleteFile.TabIndex = 12;
            this.btnDeleteFile.Text = " Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnFileExt
            // 
            this.btnFileExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFileExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnFileExt.Location = new System.Drawing.Point(639, 492);
            this.btnFileExt.Name = "btnFileExt";
            this.btnFileExt.Size = new System.Drawing.Size(46, 21);
            this.btnFileExt.TabIndex = 6;
            this.btnFileExt.Text = "Add";
            this.btnFileExt.UseVisualStyleBackColor = true;
            this.btnFileExt.Click += new System.EventHandler(this.btnFileExt_Click);
            // 
            // btnDirectoryDelete
            // 
            this.btnDirectoryDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDirectoryDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectoryDelete.Location = new System.Drawing.Point(483, 492);
            this.btnDirectoryDelete.Name = "btnDirectoryDelete";
            this.btnDirectoryDelete.Size = new System.Drawing.Size(95, 41);
            this.btnDirectoryDelete.TabIndex = 5;
            this.btnDirectoryDelete.Text = "Delete Dir.";
            this.btnDirectoryDelete.UseVisualStyleBackColor = true;
            this.btnDirectoryDelete.Click += new System.EventHandler(this.btnDirectoryDelete_Click);
            // 
            // btnOpenVideo
            // 
            this.btnOpenVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenVideo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenVideo.Location = new System.Drawing.Point(91, 492);
            this.btnOpenVideo.Name = "btnOpenVideo";
            this.btnOpenVideo.Size = new System.Drawing.Size(76, 41);
            this.btnOpenVideo.TabIndex = 2;
            this.btnOpenVideo.Text = "Open";
            this.btnOpenVideo.UseVisualStyleBackColor = true;
            this.btnOpenVideo.Click += new System.EventHandler(this.btnOpenVideo_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileInfo.Location = new System.Drawing.Point(589, 496);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(51, 23);
            this.lblFileInfo.TabIndex = 16;
            this.lblFileInfo.Text = "File Ext";
            // 
            // lblFileActions
            // 
            this.lblFileActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileActions.Location = new System.Drawing.Point(579, 516);
            this.lblFileActions.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileActions.Name = "lblFileActions";
            this.lblFileActions.Size = new System.Drawing.Size(61, 18);
            this.lblFileActions.TabIndex = 15;
            this.lblFileActions.Text = "File Copy";
            // 
            // btnCopyServer
            // 
            this.btnCopyServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyServer.Location = new System.Drawing.Point(686, 513);
            this.btnCopyServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopyServer.Name = "btnCopyServer";
            this.btnCopyServer.Size = new System.Drawing.Size(52, 21);
            this.btnCopyServer.TabIndex = 11;
            this.btnCopyServer.Text = "Server";
            this.btnCopyServer.UseVisualStyleBackColor = true;
            this.btnCopyServer.Click += new System.EventHandler(this.btnCopyServer_Click);
            // 
            // frmVideoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnCopyServer);
            this.Controls.Add(this.lblFileActions);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.btnOpenVideo);
            this.Controls.Add(this.btnFileExt);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnFindDirectories);
            this.Controls.Add(this.btnCopyFile);
            this.Controls.Add(this.btnShowFileType);
            this.Controls.Add(this.btnColumnInc);
            this.Controls.Add(this.btnColumnDec);
            this.Controls.Add(this.btnLoadVideos);
            this.Controls.Add(this.btnDirectoryDelete);
            this.Controls.Add(this.lvwVideos);
            this.Controls.Add(this.lbxDirectories);
            this.Name = "frmVideoManager";
            this.Text = "Video Manager v1.1 Final";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVideoManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView lvwVideos;
        private System.Windows.Forms.Button btnLoadVideos;
        private System.Windows.Forms.ColumnHeader Video;
        private System.Windows.Forms.Button btnColumnDec;
        private System.Windows.Forms.Button btnColumnInc;
        private System.Windows.Forms.Button btnShowFileType;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button btnFindDirectories;
        private System.Windows.Forms.Button btnDeleteFile;
        public System.Windows.Forms.ListBox lbxDirectories;
        private System.Windows.Forms.Button btnFileExt;
        private System.Windows.Forms.Button btnDirectoryDelete;
        private System.Windows.Forms.Button btnOpenVideo;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Label lblFileActions;
        private System.Windows.Forms.Button btnCopyServer;
    }
}

