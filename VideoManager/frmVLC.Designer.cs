namespace VideoManager
{
    partial class frmVLC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVLC));
            this.axVLCPlugin1 = new AxAXVLC.AxVLCPlugin();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnFastFoward = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFastFoward1Min = new System.Windows.Forms.Button();
            this.btnRewind1Min = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timPlaylist = new System.Windows.Forms.Timer(this.components);
            this.lblTimeTotal = new System.Windows.Forms.Label();
            this.lblTimeElasped = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin1)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin1
            // 
            this.axVLCPlugin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCPlugin1.Enabled = true;
            this.axVLCPlugin1.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin1.Name = "axVLCPlugin1";
            this.axVLCPlugin1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin1.OcxState")));
            this.axVLCPlugin1.Size = new System.Drawing.Size(720, 480);
            this.axVLCPlugin1.TabIndex = 7;
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullscreen.Location = new System.Drawing.Point(70, 485);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(109, 45);
            this.btnFullscreen.TabIndex = 0;
            this.btnFullscreen.Text = "Fullscreen";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewind.Location = new System.Drawing.Point(317, 503);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(62, 27);
            this.btnRewind.TabIndex = 3;
            this.btnRewind.Text = "30s";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnFastFoward
            // 
            this.btnFastFoward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFastFoward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastFoward.Location = new System.Drawing.Point(183, 503);
            this.btnFastFoward.Name = "btnFastFoward";
            this.btnFastFoward.Size = new System.Drawing.Size(62, 27);
            this.btnFastFoward.TabIndex = 1;
            this.btnFastFoward.Text = "30s";
            this.btnFastFoward.UseVisualStyleBackColor = true;
            this.btnFastFoward.Click += new System.EventHandler(this.btnFastFoward_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(452, 485);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 45);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFastFoward1Min
            // 
            this.btnFastFoward1Min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFastFoward1Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastFoward1Min.Location = new System.Drawing.Point(250, 503);
            this.btnFastFoward1Min.Name = "btnFastFoward1Min";
            this.btnFastFoward1Min.Size = new System.Drawing.Size(62, 27);
            this.btnFastFoward1Min.TabIndex = 2;
            this.btnFastFoward1Min.Text = "1m";
            this.btnFastFoward1Min.UseVisualStyleBackColor = true;
            this.btnFastFoward1Min.Click += new System.EventHandler(this.btnFastFoward1Min_Click);
            // 
            // btnRewind1Min
            // 
            this.btnRewind1Min.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRewind1Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRewind1Min.Location = new System.Drawing.Point(384, 503);
            this.btnRewind1Min.Name = "btnRewind1Min";
            this.btnRewind1Min.Size = new System.Drawing.Size(62, 27);
            this.btnRewind1Min.TabIndex = 4;
            this.btnRewind1Min.Text = "1m";
            this.btnRewind1Min.UseVisualStyleBackColor = true;
            this.btnRewind1Min.Click += new System.EventHandler(this.btnRewind1Min_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(524, 485);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(67, 45);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fast Foward";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rewind";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(596, 485);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 45);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timPlaylist
            // 
            this.timPlaylist.Enabled = true;
            this.timPlaylist.Interval = 1000;
            this.timPlaylist.Tick += new System.EventHandler(this.timPlaylist_Tick);
            // 
            // lblTimeTotal
            // 
            this.lblTimeTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeTotal.AutoSize = true;
            this.lblTimeTotal.Location = new System.Drawing.Point(669, 517);
            this.lblTimeTotal.Name = "lblTimeTotal";
            this.lblTimeTotal.Size = new System.Drawing.Size(9, 13);
            this.lblTimeTotal.TabIndex = 11;
            this.lblTimeTotal.Text = "l";
            // 
            // lblTimeElasped
            // 
            this.lblTimeElasped.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimeElasped.AutoSize = true;
            this.lblTimeElasped.Location = new System.Drawing.Point(669, 502);
            this.lblTimeElasped.Name = "lblTimeElasped";
            this.lblTimeElasped.Size = new System.Drawing.Size(9, 13);
            this.lblTimeElasped.TabIndex = 12;
            this.lblTimeElasped.Text = "l";
            // 
            // frmVLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 539);
            this.Controls.Add(this.lblTimeElasped);
            this.Controls.Add(this.lblTimeTotal);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRewind1Min);
            this.Controls.Add(this.btnFastFoward1Min);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFastFoward);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.btnFullscreen);
            this.Controls.Add(this.axVLCPlugin1);
            this.Name = "frmVLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Video Manager - VLC Player";
            this.Load += new System.EventHandler(this.frmVLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin axVLCPlugin1;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnFastFoward;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFastFoward1Min;
        private System.Windows.Forms.Button btnRewind1Min;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timPlaylist;
        private System.Windows.Forms.Label lblTimeTotal;
        private System.Windows.Forms.Label lblTimeElasped;
    }
}