using System;
using System.Collections.Generic;
using System.Text;
using Settings = VideoManager.Properties.Settings;

namespace VideoManager
{
    public class FileManipulation
    {   
        private static int intLocationExt;
        private static int intLocationBackSlash;
        private static string strFileExt;        
        private static bool fileAllowed;          
     
        public static string FileNameChange(string strFilePath, string strLabel)
        {
            int intLocationBackSlash;
            string strFilePathChange;  
            //finds location of period . in filepath variable - then pulls just the file extension with . ex. .vob
            strFileExt = GetFileExtension(strFilePath, 0);
            //Get Directory - this is used to pull out just the directory path of the selected file
            //finds location of last backslash \
            intLocationBackSlash = strFilePath.LastIndexOf(@"\");
            //pulls directory (filepath) of file with substring starting at 0 and ending at last backslash 
            strFilePathChange = strFilePath.Substring(0, intLocationBackSlash + 1);
            //builds new tag with filepath, edit label and ext
            strFilePathChange = strFilePathChange + "" + strLabel + "" + strFileExt;

            return strFilePathChange;
        }

        public static string GetFileExtension(string strFilePath, int intNoPeriod)
        {
            intLocationExt = strFilePath.LastIndexOf(".");
            strFileExt = strFilePath.Substring(intLocationExt + intNoPeriod);
            return strFileExt;
        }

        public static string GetFileName(string strFileName)
        {
            bool strFileExtShow = Settings.Default.FileType;
            intLocationExt = strFileName.LastIndexOf(".");           
            if (!strFileExtShow)
            {
                strFileName = strFileName.Substring(0, intLocationExt);
            }            
            return strFileName;
        }

        public static string GetFileNameFromPath(string strFilePath)
        {
            
            intLocationBackSlash = strFilePath.LastIndexOf(@"\");

            string strFileName = GetFileName(strFilePath.Substring(intLocationBackSlash + 1));
           
            return strFileName;
        }

        public static bool CheckFileAllowed(string strFileName)
        {
            string strFileExtAllowed;

            fileAllowed = false;
            strFileExt = GetFileExtension(strFileName, 1);
            strFileExtAllowed = Settings.Default.FileExt;

            string[] sa = strFileExtAllowed.Split(',');
            foreach (string s in sa)
            {
                if (strFileExt.ToLower() == s)
                {
                    fileAllowed = true;
                }               
            }
            return fileAllowed;
        }
        
        public static bool CheckDirectoryNotAllowed(string strFileName)
        {
            const string strDirectoryNotAllowed = "recycler,temprec,backup,system volume information";
            fileAllowed = true;
            strFileExt = GetFileExtension(strFileName, 1);
            string[] sa = strDirectoryNotAllowed.Split(',');
            foreach (string s in sa)
            {
                if (strFileExt.ToLower() == s)
                {
                    fileAllowed = false;
                }
            }
            return fileAllowed;
        }

    }
}
