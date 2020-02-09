using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Settings = VideoManager.Properties.Settings;

namespace VideoManager
{
    public partial class frmFileExt : Form
    {
        public frmFileExt()
        {
            InitializeComponent();
        }

        private void frmFileExt_Load(object sender, EventArgs e)
        {
            this.mtdLoadlbxFileExt();
        }

        public void mtdLoadlbxFileExt()
        {
            this.lbxFileExt.Items.Clear();
            string strFileExt = Settings.Default.FileExt;
            string[] sa = strFileExt.Split(',');
            foreach (string s in sa)
            {
                this.lbxFileExt.Items.Add(s.ToString());
            }
        }

        private void btnFileExtSave_Click(object sender, EventArgs e)
        {
            Settings.Default.FileExt = Settings.Default.FileExt + "," + this.tbxFileExt.Text.ToString();
            Settings.Default.Save();
            //this.Close();            
            this.mtdLoadlbxFileExt();
            this.tbxFileExt.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.lbxFileExt.Items.Remove(lbxFileExt.SelectedItem);
            string strFileExt = "";
            int i = 1;
            foreach (string s in this.lbxFileExt.Items)
            {
                if (i == 1)
                {
                    strFileExt = s;
                   
                }
                else
                {
                    strFileExt = strFileExt + "," + s;
                }
                i = i + 1;
            }
           
            Settings.Default.FileExt = strFileExt;
            Settings.Default.Save();
            this.mtdLoadlbxFileExt();
        }
    }
}