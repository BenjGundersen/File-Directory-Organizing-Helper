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
//using System.Windows.Forms;
using Microsoft.Win32;

namespace File_Directory_Organizing_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void START_Click(object sender, RoutedEventArgs e)
        {
            ///File.Delete(FileName);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog openFolderDialog1 = new OpenFolderDialog();
            openFolderDialog1.Title = "Select";
            openFolderDialog1.InitialDirectory = @"C:\";
            openFolderDialog1.ShowDialog();
        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
    }
}