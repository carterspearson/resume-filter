using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//using Spire.Doc;
//using Spire.Doc.Documents;

namespace ResumeFilterGUI
{
    public static class FolderFunctions
    {
        public static void SortPDF(Resume pdf)
        {
            bool duplicate = false;
            if (pdf.pass)
            {
                string[] approvedArray = Directory.GetFiles(Constants.APPROVEDFOLDER);
                foreach (string s in approvedArray)
                {
                    if (System.IO.Path.GetFileName(s) == System.IO.Path.GetFileName(pdf.path))
                        duplicate = true;
                }

                if (!duplicate)
                    File.Copy(pdf.path, Constants.APPROVEDFOLDER + @"\" + System.IO.Path.GetFileName(pdf.path));
            }
            else
            {
                string[] rejectedArray = Directory.GetFiles(Constants.REJECTEDFOLDER);
                foreach (string s in rejectedArray)
                {
                    if (System.IO.Path.GetFileName(s) == System.IO.Path.GetFileName(pdf.path))
                        duplicate = true;
                }

                if (!duplicate)
                    File.Copy(pdf.path, Constants.REJECTEDFOLDER + @"\" + System.IO.Path.GetFileName(pdf.path));
            }
        }

        public static void deleteFiles(string path1, string path2)
        {
            DirectoryInfo di1 = new DirectoryInfo(path1);
            DirectoryInfo di2 = new DirectoryInfo(path2);

            foreach (FileInfo file in di1.GetFiles())
                file.Delete();

            foreach (FileInfo file in di2.GetFiles())
                file.Delete();
        }

        public static List<string> GetFilesByExtensions(string path, params string[] extensions)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            List<string> files = new List<string>();
            foreach (string ext in extensions)
            {
                foreach (FileInfo f in dir.GetFiles(ext))
                    files.Add(f.FullName);
            }
            return files;
        }
    }
}
