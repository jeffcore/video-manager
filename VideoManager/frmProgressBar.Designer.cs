namespace VideoManager
{
    partial class frmProgressBar
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
            this.pgbFileCopy = new System.Windows.Forms.ProgressBar();
            this.lblCopyName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgbFileCopy
            // 
            this.pgbFileCopy.Location = new System.Drawing.Point(12, 37);
            this.pgbFileCopy.Name = "pgbFileCopy";
            this.pgbFileCopy.Size = new System.Drawing.Size(247, 23);
            this.pgbFileCopy.TabIndex = 0;
            // 
            // lblCopyName
            // 
            this.lblCopyName.AutoSize = true;
            this.lblCopyName.Location = new System.Drawing.Point(15, 12);
            this.lblCopyName.Name = "lblCopyName";
            this.lblCopyName.Size = new System.Drawing.Size(35, 13);
            this.lblCopyName.TabIndex = 1;
            this.lblCopyName.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(268, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 72);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCopyName);
            this.Controls.Add(this.pgbFileCopy);
            this.Name = "frmProgressBar";
            this.Text = "Copying File";
            this.Load += new System.EventHandler(this.frmProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbFileCopy;
        private System.Windows.Forms.Label lblCopyName;
        private System.Windows.Forms.Button btnClose;
    }
}