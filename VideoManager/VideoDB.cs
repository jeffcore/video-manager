using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections.Specialized;

namespace VideoManager
{
    class VideoDB
    {
        public static List<VideoObj> GetVideos(string strDirPath)
        {           
            List<VideoObj> videos = new List<VideoObj>();

            DirectoryInfo dir = new DirectoryInfo(strDirPath);
            
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo fi in files)
            {
                if (FileManipulation.CheckFileAllowed(fi.Name))
                {
                    VideoObj videoobj = new VideoObj();

                    videoobj.FileName = FileManipulation.GetFileName(fi.Name);
                    videoobj.FilePath = fi.FullName;
                    videoobj.ImageIndex = 1;

                    videos.Add(videoobj);
                }
            }

            return videos;
        }

        public static List<VideoObj> GetDirectories(string strDirPath)
        {           
            List<VideoObj> directories = new List<VideoObj>();

            DirectoryInfo dir = new DirectoryInfo(strDirPath);
            
            DirectoryInfo[] dirs = dir.GetDirectories();
            //load the directories
            foreach (DirectoryInfo di in dirs)
            {
                if (FileManipulation.CheckDirectoryNotAllowed(di.Name))
                {
                    VideoObj videoobj = new VideoObj();
                    
                    videoobj.FileName = "Folder - " + di.Name;
                    videoobj.FilePath = di.FullName;
                    videoobj.ImageIndex = 0;

                    directories.Add(videoobj);               
                }
            }                        
          
            return directories;
        }
    }
   
}
