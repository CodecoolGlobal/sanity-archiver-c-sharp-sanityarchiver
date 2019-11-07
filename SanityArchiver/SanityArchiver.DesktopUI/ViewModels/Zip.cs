using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace SanityArchiver.DesktopUI.ViewModels
{
    public class Zip
    { 
        public List<string> PathList {get; set; }
        

        public void AskForArchiveName(string text)
        {
            
            var dialogWindow = new Views.ZipBox();
            dialogWindow.SelectedFiles = PathList;            
            
        }
    }
}
