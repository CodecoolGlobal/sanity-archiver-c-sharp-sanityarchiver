using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver.DesktopUI.ViewModels
{
    public class MoveViewModel
    {
        public static void CopyFile(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName, true);
        }

        public static void MoveFile(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }
    }
}
