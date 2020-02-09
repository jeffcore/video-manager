using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace VideoManager
{
    public partial class frmProgressBar : Form
    {
        private long intSize;
        public string copyFilePathName;
        public string copyFileName;
        public string copyFileDestinationPath;

        public delegate void ChangeProgressBar();
        public ChangeProgressBar myDelegate;

        public delegate void CloseProgressBar();
        public CloseProgressBar myDelegateClose;

        public delegate void FillVideosRoot(string strDirPath);
        public event FillVideosRoot LoadVideos;
        
        public frmProgressBar()
        {
            InitializeComponent();
        }

        public frmProgressBar(long intFileSize, string filePathName, string fileName, string fileDestinationPath )
        {
            InitializeComponent();
            intSize = intFileSize;
            copyFilePathName = filePathName;
            copyFileName = fileName;
            copyFileDestinationPath = fileDestinationPath;
        }

        private void frmProgressBar_Load(object sender, EventArgs e)
        {
            myDelegate = new ChangeProgressBar(HandleCopyChange);
            myDelegateClose = new CloseProgressBar(Close_ProgressBar);
            double maxSize = (Convert.ToDouble(intSize) * .01);
            this.pgbFileCopy.Maximum = (int) maxSize;
            MessageBox.Show(this.pgbFileCopy.Maximum.ToString());
            this.pgbFileCopy.Minimum = 1;
            this.pgbFileCopy.Step = 450;

            this.lblCopyName.Text = "Copying " + copyFileName + @" to " + copyFileDestinationPath;
            this.Text = "Copying File " + copyFileName;

            Thread thdCopyFile = new Thread(new ThreadStart(CopyFile));
            thdCopyFile.Start();
        }

        public void HandleCopyChange()
        {
            this.pgbFileCopy.PerformStep();
        }

        private void CopyFile()
        {           
           // string strExt = FileManipulation.GetFileExtension(copyFilePathName, 0);
            string originalPath = copyFilePathName;
            string destinationPath = copyFileDestinationPath + copyFileName;

            using (FileStream fRStream = File.OpenRead(originalPath))
            {
                byte[] bytes = new byte[45000];

                long numBytesToRead = fRStream.Length;
                
                using (FileStream fWStream = File.Create(destinationPath))
                {
                    while (numBytesToRead > 0L)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fRStream.Read(bytes, 0, bytes.Length);
                        // The end of the file is reached.
                        if (n == 0)
                        {
                            break;
                        }
                        if (n == bytes.Length)
                        {
                            // Write data the destination file.
                            fWStream.Write(bytes, 0, bytes.Length);
                        }
                        else
                        {
                            fWStream.Write(bytes, 0, n);
                        }
                        numBytesToRead -= (long)n;

                        // Notify observer                       
                        this.Invoke(this.myDelegate);
                    }

                    this.Invoke(this.myDelegateClose);                  
                }             
            }          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Close_ProgressBar()
        {
            LoadVideos("root");
            this.Close();            
        }   
    }
}