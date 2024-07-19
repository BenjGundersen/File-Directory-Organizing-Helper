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
        private InfoWindow infoWindow;
        public OptionsWindow(InfoWindow infoWindow)
        {
            InitializeComponent();
            this.infoWindow = infoWindow;

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

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            if (darkModeCheckbox.IsChecked == true)
            {
                options_Grid:Background = System.Windows.Media.Brushes.DimGray;
                var mainWindow = Application.Current.MainWindow as MainWindow;
                if (mainWindow != null)
                {
                    mainWindow.main_grid.Background = System.Windows.Media.Brushes.DimGray;
                }

                if (infoWindow != null)
                {
                    infoWindow.UpdateBackground(System.Windows.Media.Brushes.DimGray);
                }
            }
            

        }
    }
}
