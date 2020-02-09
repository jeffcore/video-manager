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
    public class DirectoryList
    {
        private List<DirectoryObj> directories;

        public DirectoryList() 
        {
            directories = new List<DirectoryObj>();
        }
        
        public int Count
        {
            get
            {
                return directories.Count;
            }
        }

        public DirectoryObj this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= directories.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return directories[i];
            }
            set
            {
                directories[i] = value;
               
            }
        }

        public void Fill()
        {
            directories = DirectoryDB.GetDirectories();
        }


    }
}
