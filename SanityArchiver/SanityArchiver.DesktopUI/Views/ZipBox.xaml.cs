﻿using SanityArchiver.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SanityArchiver.DesktopUI.ViewModels;

namespace SanityArchiver.DesktopUI.Views
{
    /// <summary>
    /// Interaction logic for ZipBox.xaml
    /// </summary>
    public partial class ZipBox : Window
    {
        public List<string> SelectedFiles = new List<string>();
        public ZipBox()
        {
            InitializeComponent();
            
        }
        
        public string ResponseText
        {
            get { return ResponseTextBox.Text; }
            set { ResponseTextBox.Text = value; }
        }

        private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = true;
            ZipFileCreator.CreateZipFile(SelectedFiles, ResponseText);
        }
       
    }
} 
