using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace ResumeFilterGUI
{
    public static class Constants
    {
        public static string APPROVEDFOLDER = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Approved";
        public static string REJECTEDFOLDER = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Rejected";
        public static string INPUTFOLDER = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Input";
    }
}
