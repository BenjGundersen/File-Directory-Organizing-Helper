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

namespace File_Directory_Organizing_Helper
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private static List<string> fileTypesList = new List<string>();
        public static List<string> GetFileTypesList()
        {
            return fileTypesList;
        }
        

        private void addExtensionToListButton_Click(object sender, RoutedEventArgs e)
        {
            string content = ("." + InputFileExtension.Text);
            fileTypesList.Add(content);
            string concatenatedStrings = string.Join("\n", fileTypesList);
            ListOfExtensions.Text = concatenatedStrings;
            InputFileExtension.Text = "";
        }

        private void ClearListButton_OnClick(object sender, RoutedEventArgs e)
        {
            fileTypesList.Clear();
            ListOfExtensions.Text = "";
        }
    }
}
