using System.IO.Enumeration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System;
using System.Reflection.Metadata;

namespace File_Directory_Organizing_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        //String directory = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog openFolderDialog1 = new OpenFolderDialog();
            openFolderDialog1.Title = "Select Folder";
            openFolderDialog1.InitialDirectory = @"C:\";
            openFolderDialog1.ShowDialog();
            directory.Text = openFolderDialog1.FolderName;
        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            //imagesCheckbox_Checked();
            string sourceDirectory = directory.Text;
            DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Images\\");
            string newDirectory = di.FullName;

                var gifs = Directory.EnumerateFiles(sourceDirectory, "*.gif", SearchOption.AllDirectories);
                foreach (var gif in gifs)
                {
                    string fileName = gif.Substring(sourceDirectory.Length + 1);
                    Directory.Move(gif, System.IO.Path.Combine(newDirectory, fileName));
                }
        }

        private void imagesCheckbox_Checked()
        {

            var jpgs = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            foreach (var jpg in jpgs)
            {
                string fileName = jpg.Substring(sourceDirectory.Length + 1);
                Directory.Move(jpg, System.IO.Path.Combine(newDirectory, fileName));
            }
            
        }
    }
}