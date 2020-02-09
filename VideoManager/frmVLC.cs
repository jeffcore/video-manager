using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoManager
{
    public partial class frmVLC : Form
    {
        public string strFilePath;
        List<string> arrPlaylist;
        public string ValueFromParent        
        {
            set
            {
                strFilePath = value;
            }
        }

        public frmVLC(string initialValue, List<string> playlist)
        {           
            InitializeComponent();            
            ValueFromParent = initialValue;
            arrPlaylist = playlist;            
        }

        private void frmVLC_Load(object sender, EventArgs e)
        {
            //this.Text = "Playing - " + FileManipulation.GetFileNameFromPath(strFilePath);
            
            string[] options = { ":vout-filter=deinterlace", ":deinterlace-mode=x", ":fullscreen", ":show-intf", ":control=default" };

            for (int i = 0; i < arrPlaylist.Count; i++)
            {
                axVLCPlugin1.addTarget(arrPlaylist[i], options, AXVLC.VLCPlaylistMode.VLCPlayListInsert, i);
            }
                       
            axVLCPlugin1.play();                      
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.fullscreen();
            SendKeys.Send("f");
            Object X = axVLCPlugin1.getVariable("key-fullscreen");
            axVLCPlugin1.setVariable("key-pressed", X);
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            int vlctime = axVLCPlugin1.Time;
            if (vlctime > 30)
            {
                axVLCPlugin1.shuttle(-30);
                //axVLCPlugin1.Time -= Convert.ToInt32("30");
            }
            else
            {
                axVLCPlugin1.Time = Convert.ToInt32("00");
            }
            
        }

        private void btnFastFoward_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.shuttle(30);
            //axVLCPlugin1.Time += Convert.ToInt32("30");
                
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.play();
        }

        private void btnFastFoward1Min_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.shuttle(60);
            // axVLCPlugin1.Time += Convert.ToInt32("60");
        }

        private void btnRewind1Min_Click(object sender, EventArgs e)
        {
            int vlctime = axVLCPlugin1.Time;
            if (vlctime > 60)
            {
                axVLCPlugin1.shuttle(-60);
                //axVLCPlugin1.Time -= Convert.ToInt32("60");
            }
            else
            {
                axVLCPlugin1.Time = Convert.ToInt32("00");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axVLCPlugin1.stop();
        }

        private void timPlaylist_Tick(object sender, EventArgs e)
        {
            int intPlaylist= axVLCPlugin1.PlaylistIndex;
            strFilePath = arrPlaylist[intPlaylist];

            this.Text = "Playing - " + FileManipulation.GetFileNameFromPath(strFilePath);

            this.lblTimeElasped.Text = axVLCPlugin1.Time.ToString();
            this.lblTimeTotal.Text = axVLCPlugin1.Length.ToString();

        }

      
    }
}