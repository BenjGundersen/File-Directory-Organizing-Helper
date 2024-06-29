﻿using System.IO.Enumeration;
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

        private void documentsCheckBox_Checked()
        {
            string sourceDirectory = directory.Text;
            var docs = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".docx") || s.EndsWith(".pdf") || s.EndsWith(".xlsx"));

            if (docs is not null)
            {
                DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Documents\\");
                string newDirectory = di.FullName;
                foreach (var document in docs)
                {
                    string filename = document.Substring(sourceDirectory.Length + 1);
                    Directory.Move(document, System.IO.Path.Combine(newDirectory, filename));
                }
            }
        }

        private void videosCheckBox_Checked()
        {
            string sourceDirectory = directory.Text;
            var videos = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".mp4") || s.EndsWith(".mkv") || s.EndsWith(".webm"));

            if (videos is not null)
            {
                DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Videos\\");
                string newDirectory = di.FullName;
                foreach (var video in videos)
                {
                    string filename = video.Substring(sourceDirectory.Length + 1);
                    Directory.Move(video, System.IO.Path.Combine(newDirectory, filename));
                }
            }
        }

        private void imageCheckBox_Checked()
        {
            string sourceDirectory = directory.Text;
            var images = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".webp") || s.EndsWith(".gif"));

            if (images is not null)
            {
                DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Videos\\");
                string newDirectory = di.FullName;
                foreach (var image in images)
                {
                    string filename = image.Substring(sourceDirectory.Length + 1);
                    Directory.Move(image, System.IO.Path.Combine(newDirectory, filename));
                }
            }
        }

        private void archivesCheckbox_Checked()
        {
            string sourceDirectory = directory.Text;
            var archives = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".rar") || s.EndsWith(".zip") || s.EndsWith(".7z"));

            if (archives is not null)
            {
                DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Archives\\");
                string newDirectory = di.FullName;
                foreach (var archive in archives) 
                {
                    string filename = archive.Substring(sourceDirectory.Length + 1);
                    Directory.Move(archive, System.IO.Path.Combine(newDirectory, filename));
                }
            }
        }

        private void executablesCheckbox_Checked()
        {
            string sourceDirectory = directory.Text;
            var exes = Directory.EnumerateFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                .Where(s => s.EndsWith(".exe") || s.EndsWith(".msi"));

            if (exes is not null)
            {
                DirectoryInfo di = Directory.CreateDirectory(directory.Text + "\\Executables\\");
                string newDirectory = di.FullName;
                foreach (var executable in exes)
                {
                    string filename = executable.Substring(sourceDirectory.Length + 1);
                    Directory.Move(executable, System.IO.Path.Combine(newDirectory, filename));
                }
            }
        }


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (documentsCheckbox.IsChecked == false && videosCheckbox.IsChecked == false && imagesCheckbox.IsChecked == false && archivesCheckbox.IsChecked == false && executablesCheckbox.IsChecked == false) 
            {
                MessageBox.Show("There are no check boxes selected! No files have been moved");
            }

            if (documentsCheckbox.IsChecked == true)
            {
                documentsCheckBox_Checked();
            }

            if (videosCheckbox.IsChecked == true)
            {
                videosCheckBox_Checked();
            }

            if (imagesCheckbox.IsChecked == true)
            {
                imageCheckBox_Checked();
            }

            if (archivesCheckbox.IsChecked == true)
            {
                archivesCheckbox_Checked();
            }

            if (executablesCheckbox.IsChecked == true)
            {
                executablesCheckbox_Checked();
            }
        }


    }
}
