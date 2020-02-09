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
    class DirectoryDB
    {
        private const string Path = @"c:\videomanager.txt";

        public static List<DirectoryObj> GetDirectories()
        {

            string strLine;
            
            FileInfo fi = new FileInfo(Path);
            if (!fi.Exists)
            {
                //if videomanage.txt does not exist it is created
                FileStream fstr = fi.Create();
                fstr.Close();
            }
           
            List<DirectoryObj> directories = new List<DirectoryObj>();

            FileStream fs = new FileStream(Path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            strLine = sr.ReadLine();
            while (strLine != null)
            {
                DirectoryObj directoryobj = new DirectoryObj();

                directoryobj.DirectoryPath = strLine;

                directories.Add(directoryobj);

                strLine = sr.ReadLine();
            }
            sr.Close();

            return directories;
        }

       





    }
}
