using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SanityArchiver.DesktopUI.Converters;
using SanityArchiver.Application.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO.Compression;
using Microsoft.VisualBasic;
using SanityArchiver.DesktopUI.ViewModels;


namespace SanityArchiver.DesktopUI.Views
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void folders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var FolderContent = new FolderContent();
            string FolderTag = ((System.Windows.FrameworkElement)folders.SelectedItem).Tag.ToString();
            SelectedFolderContain.ItemsSource = FolderContent.GetAllFiles(FolderTag);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var FolderTree = new FolderTree();
            foreach (DriveInfo driv in DriveInfo.GetDrives())
            {
                if (driv.IsReady)
                {
                    FolderTree.Populate(driv.VolumeLabel + "(" + driv.Name + ")", driv.Name, folders, null, false);
                }
            }
        }
        private void isFileSelected(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            var dataContext = (Application.Models.FileProperties)checkBox.DataContext;
            string filePath = dataContext.CheckboxName;
            FolderContent.CheckIfEncryptable(filePath, Encrypt);
            
        }
        

    }
}
