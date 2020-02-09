using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Settings = VideoManager.Properties.Settings;

namespace VideoManager
{
    public partial class frmVideoManager : Form
    {
              
        private StringCollection folderCol;
        List<DirectoryObj> directories;
      
        public frmVideoManager()
        {
            InitializeComponent();
        }
        
        private void frmVideoManager_Load(object sender, EventArgs e)
        {
            folderCol = new StringCollection();
            folderCol.Add(@"root");

            //Sets initial movies listview previous directory preference to root, every time you load the program it always loads the "root" directories in listbox
            Settings.Default.DirectoryPrevious = "root";
            Settings.Default.Save();
         
            //Loads Directories From Object and Fill Directories Listbox
            directories = DirectoryDB.GetDirectories();                              
            this.FillLbxDirectoriesFromText();

            //Creates default directory on hard drive to store videos
            if (Convert.ToString(Directory.Exists(@"c:\vm_videos\")) == "False")
            {
                Directory.CreateDirectory(@"c:\vm_videos\");
            }

            //Sets width of colums based on previous changes stored in preferences
            this.lvwVideos.Columns[0].Width = this.lvwVideos.Columns[0].Width + Settings.Default.ColumnWidth;
        }
       
        //!!!Move to own db object, this writes directories in listbox to directories file
        private void WritelbxDirectoriesToText()
        {
            StreamWriter sw = new StreamWriter(@"C:\videomanager.txt");
            foreach (object o in lbxDirectories.Items)
            {
                sw.WriteLine(o);
            }
            sw.Close();
        }

        //!!Move to own db object, Populates directory listbox from directoryobj list
        private void FillLbxDirectoriesFromText()
        {
            this.lbxDirectories.Items.Clear();
            foreach (DirectoryObj d in directories)
            {
                this.lbxDirectories.Items.Add(d.DirectoryPath);
            }

            this.FillVideos(Settings.Default.DirectoryPrevious);               
        }

        //!!Move to own db object, Fills listview with all videos in directories
        public void FillVideos(string strDirPath)
        {
            // FillVideos Method fills the listview with subfolders and allowed files 
            //    from all directories om videosdirectory listbox
            //    the intext parameter is the show file extension button
            //---------------------------
            //clears videos from video listview
            this.lvwVideos.Items.Clear();

            ListViewItem lvi;
            if (strDirPath != "root")
            {
                lvi = new ListViewItem();
                lvi.Text = "Back";
                lvi.ImageIndex = 2;
                lvi.Tag = Settings.Default.DirectoryPrevious;
                this.lvwVideos.Items.Add(lvi);
                Settings.Default.DirectoryPrevious = strDirPath;
                Settings.Default.Save();
            }
           
            //loads videomanager.txt into filestream 
            if (strDirPath != "root")
            {               
            
                List<VideoObj> videos;

                videos = VideoDB.GetDirectories(strDirPath);

                foreach (VideoObj v in videos)
                {
                    lvi = new ListViewItem();
                    lvi.Text = v.FileName;
                    lvi.Tag = v.FilePath;
                    lvi.ImageIndex = v.ImageIndex;
                    this.lvwVideos.Items.Add(lvi);
                }                
                
                videos = VideoDB.GetVideos(strDirPath);

                foreach (VideoObj v in videos)
                {                   
                    lvi = new ListViewItem();
                    lvi.Text = v.FileName;
                    lvi.Tag = v.FilePath;
                    lvi.ImageIndex = v.ImageIndex;
                    this.lvwVideos.Items.Add(lvi);
                }
                              
                if (lbxDirectories.Items.Count > 0)
                {
                    this.lvwVideos.Items[0].Selected = true;
                }
            }
            else
            {
                foreach (DirectoryObj d in directories)
                {
                   //checks to see if directory exists
                    if (Directory.Exists(d.DirectoryPath))
                    {
                        List<VideoObj> videos;

                        videos = VideoDB.GetDirectories(d.DirectoryPath);

                        foreach (VideoObj v in videos)
                        {                           
                            lvi = new ListViewItem();
                            lvi.Text = v.FileName;
                            lvi.Tag = v.FilePath;
                            lvi.ImageIndex = v.ImageIndex;
                            this.lvwVideos.Items.Add(lvi);
                        }
                    }  
                }

                foreach (DirectoryObj d in directories)
                {
                    if (Directory.Exists(d.DirectoryPath))
                    {                            
                        List<VideoObj> videos;

                        videos = VideoDB.GetVideos(d.DirectoryPath);
                     
                        foreach (VideoObj v in videos)
                        {
                            lvi = new ListViewItem();
                            lvi.Text = v.FileName;
                            lvi.Tag = v.FilePath;
                            lvi.ImageIndex = v.ImageIndex;
                            this.lvwVideos.Items.Add(lvi);
                        }
                    }
                }
                if (lbxDirectories.Items.Count > 0)
                {
                    this.lvwVideos.Items[0].Selected = true;
                }
            }
        }

        private void WriteDirectoryText(string strDirPath)
        {
            int intTrue = 0;
            foreach (object o in lbxDirectories.Items)
            {
                if (o.ToString() == strDirPath)
                {
                    //does not show error if c:\vm_videos exists
                    if (strDirPath != @"c:\vm_videos\")
                    {
                        MessageBox.Show("Directory Already Added " + strDirPath);
                    }
                    intTrue = 1;
                }
            }
            if (intTrue == 0)
            {                  
                DirectoryObj d = new DirectoryObj();
                d.DirectoryPath = strDirPath;                
                directories.Add(d);

                this.FillLbxDirectoriesFromText();
                this.WritelbxDirectoriesToText();
                this.FillVideos(Settings.Default.DirectoryPrevious);
            }
        }

 //End of Methods - Video Form Events Start Here
       
        private void btnFindDirectories_Click(object sender, EventArgs e)
        {
            //opens folderbrowser dialog and closes if user clicks ok
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.WriteDirectoryText(folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnDirectoryDelete_Click(object sender, EventArgs e)
        {
            int i = lbxDirectories.SelectedIndex;
            this.lbxDirectories.Items.Remove(lbxDirectories.SelectedItem);
            directories.RemoveAt(i);          
            this.WritelbxDirectoriesToText();          
            this.FillVideos(Settings.Default.DirectoryPrevious);
        }

        private void btnLoadVideos_Click(object sender, EventArgs e)
        {
            this.FillVideos("root");
        }

        private void lvwVideos_ItemActivate(object sender, EventArgs e)
        {           
            //code for making the video files active...so you can play them            
            ListView lw = (ListView)sender;
            string strFilenamePath = lw.SelectedItems[0].Tag.ToString();
            
            //get playlist
            int intVideoIndex = lw.SelectedItems[0].Index;
            List<string> playlist = new List<string>();

            for (int i = intVideoIndex; i < (intVideoIndex + 30); i++)
            {
                try 
	            {
                    playlist.Add(this.lvwVideos.Items[i].Tag.ToString());
	            }
	            catch 
	            {            		
		            break;
	            }
            }           
           
            string strFileExt;            
            if (lw.SelectedItems[0].ImageIndex == 1)
            {
                try
                {
                    strFileExt = FileManipulation.GetFileExtension(strFilenamePath, 1);

                    if (strFileExt == "pdf")
                    {                        
                        System.Diagnostics.Process.Start(strFilenamePath);
                    }

                    frmVLC vlc = new frmVLC(strFilenamePath, playlist);
                    vlc.Show();
                }
                catch
                {
                    return;
                }
            }
            else if (lw.SelectedItems[0].ImageIndex == 0)
            {
                this.FillVideos(strFilenamePath);
                folderCol.Add(strFilenamePath);
            }
            else if (lw.SelectedItems[0].ImageIndex == 2)
            {
                Settings.Default.DirectoryPrevious = "root";
                Settings.Default.Save();
                if (folderCol.Count > 1)
                {
                    this.FillVideos(folderCol[folderCol.Count - 2].ToString());
                    folderCol.RemoveAt(folderCol.Count - 1);
                }
                else
                {
                    this.FillVideos(strFilenamePath);  
                }

                this.FillVideos(strFilenamePath);               
            }
        }

        private void btnColumnDec_Click(object sender, EventArgs e)
        {
            this.lvwVideos.Columns[0].Width = this.lvwVideos.Columns[0].Width - 25;
            Settings.Default.ColumnWidth = Settings.Default.ColumnWidth - 25;
            Settings.Default.Save();
        }

        private void btnColumnInc_Click(object sender, EventArgs e)
        {
            this.lvwVideos.Columns[0].Width = this.lvwVideos.Columns[0].Width + 25;
            Settings.Default.ColumnWidth = Settings.Default.ColumnWidth + 25;
            Settings.Default.Save();
        }

        private void btnShowFileType_Click(object sender, EventArgs e)
        {
            if (Settings.Default.FileType == false)
            {
                Settings.Default.FileType = true;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.FileType = false;
                Settings.Default.Save();
            }

            this.FillVideos(Settings.Default.DirectoryPrevious);           
        }

        private void lvwVideos_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            //grabs the changed name of file after user does edit ex. Barney 
            string strLabel = e.Label;
            //grabs name of selected file with extension ex. Barney.vob
            string strFilePathOld = this.lvwVideos.SelectedItems[0].Tag.ToString();
            if (strLabel != null)
            {                       
               // FileManipulation objFileNameChange = new FileManipulation(strFilePathOld);
                string strFilePathChange = FileManipulation.FileNameChange(strFilePathOld, strLabel);
               
                if (strFilePathOld != strFilePathChange)
                {
                    if (Convert.ToString(File.Exists(strFilePathChange)) == "False")
                    {
                        File.Move(strFilePathOld, strFilePathChange);
                        this.lvwVideos.SelectedItems[0].Tag = strFilePathChange;
                    }
                    else
                    {
                        if (MessageBox.Show("File Name Not Changed It Already Exists - " + strLabel, "File Name Change Error", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.FillVideos(Settings.Default.DirectoryPrevious);
                        }
                    }
                }
            }        
        }

      
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string strFilePathName = this.lvwVideos.SelectedItems[0].Tag.ToString();

            if (File.Exists(strFilePathName))
            {
                if (MessageBox.Show("Do you want to delete this file: " + strFilePathName, "File Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(strFilePathName);
                    this.FillVideos(Settings.Default.DirectoryPrevious);
                }
            }
        }   

        private void btnFileExt_Click(object sender, EventArgs e)
        {
            frmFileExt frmFileExtDialog = new frmFileExt();        
            frmFileExtDialog.Show();
        }

        private void btnOpenVideo_Click(object sender, EventArgs e)
        {
            //code for making the video files active...so you can play them
            try
            {
                string strFilenamePath = lvwVideos.SelectedItems[0].Tag.ToString();
                string strFileExt;

                //get playlist
                int intVideoIndex = lvwVideos.SelectedItems[0].Index;
                List<string> playlist = new List<string>();

                for (int i = intVideoIndex; i < (intVideoIndex + 30); i++)
                {
                    try
                    {
                        playlist.Add(this.lvwVideos.Items[i].Tag.ToString());
                    }
                    catch
                    {
                        break;
                    }
                }   
                
                
                
                if (lvwVideos.SelectedItems[0].ImageIndex == 1)
                {
                    try
                    {
                        strFileExt = FileManipulation.GetFileExtension(strFilenamePath, 1);

                        if (strFileExt == "pdf")                        
                            System.Diagnostics.Process.Start(strFilenamePath);
                        
                        frmVLC vlc = new frmVLC(strFilenamePath, playlist);                        
                        vlc.Show();
                    }
                    catch
                    {
                        return;
                    }
                }
                else if (lvwVideos.SelectedItems[0].ImageIndex == 0)
                {
                    this.FillVideos(strFilenamePath);
                    folderCol.Add(strFilenamePath);
                }
                else if (lvwVideos.SelectedItems[0].ImageIndex == 2)
                {
                    Settings.Default.DirectoryPrevious = "root";
                    Settings.Default.Save();
                    if (folderCol.Count > 1)
                    {
                        this.FillVideos(folderCol[folderCol.Count - 2].ToString());
                        folderCol.RemoveAt(folderCol.Count - 1);
                    }
                    else
                    {
                        this.FillVideos(strFilenamePath);
                    }

                    this.FillVideos(strFilenamePath);
                }              
            }
            catch
            {
                return;
            }
        }
        
        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            string copyFilePath = this.lvwVideos.SelectedItems[0].Tag.ToString();
            FileInfo fi = new FileInfo(copyFilePath);
            long copyFileSize = fi.Length;
            string copyFileName = fi.Name;
            string copyFileDestinationPath = @"c:\vm_videos\";
         
            //  MessageBox.Show(fi.Length.ToString() + " --- " + fileSize.ToString());
            //  string strCFFileName = this.lvwVideos.SelectedItems[0].Text.ToString();
            //  string strExt = FileManipulation.GetFileExtension(copyFilePath, 0);

            if (File.Exists(copyFileDestinationPath + copyFileName))
            {
                MessageBox.Show("This File Already Exists", "File Copy Error");
            }
            else
            {
                this.WriteDirectoryText(copyFileDestinationPath);

                frmProgressBar pg = new frmProgressBar(copyFileSize, copyFilePath, copyFileName, copyFileDestinationPath);
                pg.Show();

                pg.LoadVideos += new frmProgressBar.FillVideosRoot(FillVideos);
            }
        }       

        private void btnCopyServer_Click(object sender, EventArgs e)
        {
            string copyFilePath = this.lvwVideos.SelectedItems[0].Tag.ToString();
            FileInfo fi = new FileInfo(copyFilePath);
            long copyFileSize = fi.Length;
            string copyFileName = fi.Name;
            string copyFileDestinationPath = @"\\Videoserver\vs3 kids (f)\kids\";
           
            //MessageBox.Show(fileSize.ToString());
            //string strCFFilePathName = this.lvwVideos.SelectedItems[0].Tag.ToString();
            //string strCFFileName = this.lvwVideos.SelectedItems[0].Text.ToString();                        
            //string strExt = FileManipulation.GetFileExtension(strCFFilePathName, 0);

            if (File.Exists(@"\\Videoserver\vs3 kids (f)\kids\" + copyFileName))
            {
                MessageBox.Show("This File Already Exists", "File Copy Error");
            }
            else
            {
                frmProgressBar pg = new frmProgressBar(copyFileSize, copyFilePath, copyFileName, copyFileDestinationPath);
                pg.Show();

                pg.LoadVideos += new frmProgressBar.FillVideosRoot(FillVideos);
            }
        }    
    }
}