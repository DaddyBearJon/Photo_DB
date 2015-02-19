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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace PhotoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddPictures : Window
    {
        public AddPictures()
        {
            InitializeComponent();
        }

        // Any control that causes the Window.Closing even to trigger.
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void btnViewDB_Click(object sender, RoutedEventArgs e)
        {
            ViewPictures obj = new ViewPictures();
            obj.Show();

        }


        private void AddPicture_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var response = System.Windows.MessageBox.Show("Do you really want to exit?", "Exiting...",
                                           MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
         
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Picture"; // Default file name
            dlg.DefaultExt = ".jpg"; // Default file extension
            dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png| JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg| Portable Network Graphic (*.png)|*.png";

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                imagebox.Source = new BitmapImage(new Uri(dlg.FileName));
                tbTextBox.Text = dlg.FileName.ToString();
            }
        }

        private void btnCreateFolder_Click(object sender, RoutedEventArgs e)
        {
            AddFolder obj = new AddFolder();
            obj.Show();
        }
    }
}
