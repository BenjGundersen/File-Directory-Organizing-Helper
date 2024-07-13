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

        List<string> fileTypesList = new List<string>();

        string input;

        private void addExtensionToListTextBox(string fileType)
        {
            listOfExtensions.Text(fileType, "\n");
        }

        private void addExtensionToListButton_Click(object sender, RoutedEventArgs e)
        {
            string content = inputFileExtension.Text;
            fileTypesList.Add(content);
            addExtensionToListTextBox(content);
            inputFileExtension.Text.Clear();
        }
    }
}
