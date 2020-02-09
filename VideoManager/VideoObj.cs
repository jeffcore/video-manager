using System;
using System.Collections.Generic;
using System.Text;

namespace VideoManager
{
    public class VideoObj
    {
        private string fileName;
        private string filePath;
        private int imageIndex;

        public VideoObj() { }

        public VideoObj(string fileName, string filePath, int imageIndex) 
        {
            this.FileName = fileName;
            this.FilePath = filePath;
            this.ImageIndex = imageIndex;
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        public int ImageIndex
        {
            get
            {
                return imageIndex;
            }
            set
            {
                imageIndex = value;
            }
        }
    }
}
