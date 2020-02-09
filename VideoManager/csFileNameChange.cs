using System;
using System.Collections.Generic;
using System.Text;

namespace VideoManager
{
    class csFileNameChange
    {
        private int intLocationExt;
        private int intLocationBackSlash;
        private string strFilePathChange;
        private string strFilePath;
        private string strExt;

        public csFileNameChange(){}
        
        public csFileNameChange(string strFilePath)
        {
            this.StrFilePath = strFilePath;
        }

        public string StrFilePath
        {
            get
            {
                return strFilePath;
            }
            set
            {
                strFilePath = value;
            }
        }

        public string GetFileExtension()
        {
            intLocationExt = strFilePath.IndexOf(".");
            strExt = strFilePath.Substring(intLocationExt);
            return strExt;
        }

        public string FileNameChange(string strLabel)
        {
            //finds location of period . in filepath variable - then pulls just the file extension with . ex. .vob
            strExt = this.GetFileExtension();

            //Get Directory - this is used to pull out just the directory path of the selected file
            //finds location of last backslash \
            intLocationBackSlash = strFilePath.LastIndexOf(@"\");
            //pulls directory (filepath) of file with substring starting at 0 and ending at last backslash 
            strFilePathChange = strFilePath.Substring(0, intLocationBackSlash + 1);
            //builds new tag with filepath, edit label and ext
            strFilePathChange = strFilePathChange + "" + strLabel + "" + strExt;

            return strFilePathChange;

        }
    }
}
