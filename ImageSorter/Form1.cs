using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSorter
{
    public partial class Form1 : Form
    {
        private string _FromPath;
        private string _ToPath;
        private bool _recursive = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void FromPath_Click(object sender, EventArgs e)
        {
            _FromPath = GetPath();
        }
        /// <summary>
        /// Just dialog to get users path
        /// </summary>
        /// <returns></returns>
        private string GetPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            return fbd.SelectedPath;
        }

        private void ToPath_Click(object sender, EventArgs e)
        {
            _ToPath = GetPath();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            SortFiles(_FromPath);
        }
        /// <summary>
        /// Sorting files in to _ToPath/YYYY-MM
        /// </summary>
        /// <param name="folder"></param>
        private void SortFiles(string folder)
        {
            if (_recursive)
            {
                var directorys = Directory.GetDirectories(folder);
                foreach (string directory in directorys)
                {
                    SortFiles(directory);
                }
            }
            var files = GetImageFiles(folder);
            foreach (var file in files)
            {
                DateTime fileDateTime;
                Console.Out.WriteLine(file);
                try
                {
                    fileDateTime = GetDateTakenFromImage(file);
                }
                catch (Exception)
                {
                    fileDateTime = File.GetCreationTime(file) > File.GetLastWriteTime(file)
                        ? File.GetLastWriteTime(file)
                        : File.GetCreationTime(file);
                }
                string path = string.Format("{0}\\{1:yyyy}\\{1:MMM}", _ToPath, fileDateTime);
                string Newfilepath = string.Format("{0}\\{1}", path, Path.GetFileName(file));
                string tempfilename = Newfilepath;
                int NewIntFileName = 1;
                while (File.Exists(tempfilename))
                {
                    tempfilename = string.Format("{0}({1}).{2}", Path.GetFileNameWithoutExtension(Newfilepath),NewIntFileName,Path.GetExtension(Newfilepath));
                    NewIntFileName++;
                }
                Newfilepath = tempfilename;
                
                if (!Directory.Exists(path))
                {
                        Directory.CreateDirectory(path);
                }
                Console.Out.WriteLine("kopierar");
                File.Copy(file, Newfilepath);
                

                Console.Out.WriteLine(File.GetCreationTime(file));
            }
        }
        private static IEnumerable<string> GetImageFiles(string sourceFolder)
        {
            return from file in System.IO.Directory.EnumerateFiles(sourceFolder)
                   let extension = Path.GetExtension(file)
                   where extension == ".jpg" || extension == ".gif" || extension == ".png"
                   select file;
        }

        private static Regex r = new Regex(":");

        //retrieves the datetime WITHOUT loading the whole image
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }

        
        // Change recursive option
        private void Recursive_Check_CheckedChanged(object sender, EventArgs e)
        {
            _recursive = Recursive_Check.Checked;
        }
    }
}
