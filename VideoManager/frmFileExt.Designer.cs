namespace VideoManager
{
    partial class frmFileExt
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
            this.tbxFileExt = new System.Windows.Forms.TextBox();
            this.btnFileExtSave = new System.Windows.Forms.Button();
            this.lbxFileExt = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFileExt
            // 
            this.tbxFileExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFileExt.Location = new System.Drawing.Point(66, 3);
            this.tbxFileExt.Name = "tbxFileExt";
            this.tbxFileExt.Size = new System.Drawing.Size(56, 22);
            this.tbxFileExt.TabIndex = 0;
            // 
            // btnFileExtSave
            // 
            this.btnFileExtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileExtSave.Location = new System.Drawing.Point(66, 29);
            this.btnFileExtSave.Name = "btnFileExtSave";
            this.btnFileExtSave.Size = new System.Drawing.Size(56, 24);
            this.btnFileExtSave.TabIndex = 1;
            this.btnFileExtSave.Text = "Add";
            this.btnFileExtSave.UseVisualStyleBackColor = true;
            this.btnFileExtSave.Click += new System.EventHandler(this.btnFileExtSave_Click);
            // 
            // lbxFileExt
            // 
            this.lbxFileExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFileExt.FormattingEnabled = true;
            this.lbxFileExt.ItemHeight = 16;
            this.lbxFileExt.Location = new System.Drawing.Point(5, 5);
            this.lbxFileExt.Name = "lbxFileExt";
            this.lbxFileExt.Size = new System.Drawing.Size(55, 196);
            this.lbxFileExt.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(66, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Del";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmFileExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 211);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxFileExt);
            this.Controls.Add(this.btnFileExtSave);
            this.Controls.Add(this.tbxFileExt);
            this.Name = "frmFileExt";
            this.Text = "Video Manager - Allowed File Extentions";
            this.Load += new System.EventHandler(this.frmFileExt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFileExt;
        private System.Windows.Forms.Button btnFileExtSave;
        private System.Windows.Forms.ListBox lbxFileExt;
        private System.Windows.Forms.Button btnRemove;
    }
}