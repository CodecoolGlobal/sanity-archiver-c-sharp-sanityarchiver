using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SanityArchiver.Application.Models;
using System.Windows;

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
                FileProperties file = new FileProperties()
                {
                    CheckboxName = _dirinfo.FullName,
                    FileName = _dirinfo.Name,
                    CreatedTime = _dirinfo.CreationTime,
                    Size = System.String.Format("{0}KB", _dirinfo.Length / 1024),
                };
                items.Add(file);
                file.GetFileName(_dirinfo.FullName);

            }
            return items;
        }

        public static void CheckIfEncryptable(string filePath, Button encryptButton)
        {
            if (filePath.Contains(".txt"))
            {
                encryptButton.Content = "Encrypt";
                encryptButton.Visibility = Visibility.Visible;
                encryptButton.Click += (sender, e) =>
                {
                    Encrypt.EncryptFile(filePath);
                    encryptButton.Visibility = Visibility.Hidden;
                };
            }
            if (filePath.Contains(".ENC"))
            {
                encryptButton.Content = "Decrypt";
                encryptButton.Visibility = Visibility.Visible;
                encryptButton.Click += (sender, e) =>
                {
                    Encrypt.DecryptFile(filePath);
                    encryptButton.Visibility = Visibility.Hidden;
                };
            }
        }

        public static void CheckIfCompressable(string[] _selectedFilesPath, Button zipbutton)
        {
            if(_selectedFilesPath.Length > 0)
            {
                if (_selectedFilesPath.Length == 1 & _selectedFilesPath.Contains(".zip"))
                {
                    zipbutton.Content = "Unzip";
                    zipbutton.Visibility = Visibility.Visible;
                    zipbutton.Click += (sender, e) =>
                    {
                        //ZipFileCreator.DecompressFile(_selectedFilesPath)
                        zipbutton.Visibility = Visibility.Hidden;
                    };
                }
                else
                {
                    zipbutton.Content = "Compress";
                    zipbutton.Visibility = Visibility.Visible;
                    zipbutton.Click += (sender, e) =>
                    {
                        //ZipFileCreator.CreateZipFile(_selectedFilesPath)
                        zipbutton.Visibility = Visibility.Hidden;
                    };
                }
               
            }
            else
            {

            }
        }

        private static void Zipbutton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
