using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoManager
{
    public class DirectoryObj
    {
        public DirectoryObj()
        {
        }

        private string directoryPath;
        public DirectoryObj(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        public string DirectoryPath
        {
            get
            {
                return directoryPath;
            }
            set
            {
                directoryPath = value;
            }

        }
    }
}
