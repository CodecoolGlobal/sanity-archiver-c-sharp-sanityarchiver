using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SanityArchiver.Application.Models;

namespace SanityArchiver.DesktopUI.ViewModels
{
    class FolderContent
    {
        public List<FileProperties> GetAllFiles(string FolderPath)
        {
            var items = new List<FileProperties>();
            foreach (string dir in Directory.GetFiles(FolderPath))
            {
                FileInfo _dirinfo = new FileInfo(dir);
                items.Add(new FileProperties() { CheckboxName = _dirinfo.FullName, FileName = _dirinfo.Name, CreatedTime = _dirinfo.CreationTime, Size = System.String.Format("{0}KB", _dirinfo.Length / 1024) });

            }
            return items;
        }
    }
}
