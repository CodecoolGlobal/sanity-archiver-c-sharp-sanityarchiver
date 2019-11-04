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
            if (e.Source is TreeViewItem && ((TreeViewItem)e.Source).IsSelected)
            {
                

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var FolderTree = new FolderTree();
            foreach (DriveInfo driv in DriveInfo.GetDrives())
            {
                if (driv.IsReady)
                {
                    FolderTree.Folder
                    FolderTree.Populate(driv.VolumeLabel + "(" + driv.Name + ")", driv.Name, folders, null, false);                    
                }
            }

        }

    }
}
