using System;
using System.IO;
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
using System.Windows.Forms;
using Microsoft.Maps.MapControl.WPF;
using ExifDataTags.Exif;
using System.Drawing;

namespace PhotoApp
{
    /// <summary>
    /// Interaction logic for ViewPictures.xaml
    /// </summary>
    /// 
    public class MyExifData
    {
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }

    public partial class ViewPictures : Window
    {
        decimal GPSLatitude;
        decimal GPSLongitude;

        public ViewPictures()
        {
            InitializeComponent();
        }

        private ExifTagCollection _exif;

        private void AddTagToList(ExifTag tag)
        {
            lvExifData.Items.Add(new MyExifData() { FieldName = tag.FieldName, Description = tag.Description, Value = tag.Value });
        }

        private static decimal Lat_Long_Deg_To_Dec(string Loc)
        {
            string Degrees;
            string Minutes;
            string Seconds;
            decimal Deg;
            decimal Min;
            decimal Sec;
            decimal result;

            try
            {
                string[] splitString = Loc.Split(',');

                Degrees = splitString[0].Trim();
                Minutes = splitString[1].Trim();
                Seconds = splitString[2].Trim();

                Deg = Convert.ToDecimal(Degrees);
                Min = Convert.ToDecimal(Minutes);
                Sec = Convert.ToDecimal(Seconds);

                result = decimal.Round((Deg + (Min / 60) + (Sec / 3600)), 6);
                return result;
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return 0;
            }
        }

        private void getDateTaken(string dateTaken)
        {
            string year;
            string month;
            string day;
            decimal y;
            decimal m;
            decimal d;

            try
            {
                string[] splitString = dateTaken.Split(':');

                year = splitString[0].Trim();
                month = splitString[1].Trim();
                day = splitString[2].Trim();

                y = Convert.ToDecimal(year);
                m = Convert.ToDecimal(month);
                d = Convert.ToDecimal(day);
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(Environment.CurrentDirectory = (@"C:\Users"));
            FileInfo[] images = folder.GetFiles("*.jpg");
            foreach (FileInfo img in images)
            {
                Photos.Items.Add(img.FullName);
            }

            LocationMap.Mode = new AerialMode(true);
            LocationMap.Center = new Microsoft.Maps.MapControl.WPF.Location(Convert.ToDouble(Latitude.Text), Convert.ToDouble(Longitude.Text));
            Pushpin pin = new Pushpin();
            pin.Location = LocationMap.Center;
            // Adds the pushpin to the map.
            LocationMap.Children.Add(pin);
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            Photos.Items.Clear();
            string folderLoc;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                folderLoc = fbd.SelectedPath;
                try
                {
                    DirectoryInfo folder = new DirectoryInfo(folderLoc);
                    FileInfo[] images = folder.GetFiles("*.jpg");
                    foreach (FileInfo img in images)
                    {
                        Photos.Items.Add(img.FullName);
                    }
                }
                catch (Exception file_err)
                {
                    System.Windows.MessageBox.Show(file_err.Message);
                }
            }
        }

        private void Photos_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            bool SouthLatitude = false;
            bool WestLongitude = false;

            String selectedImage = (String)Photos.SelectedItem;

            if (selectedImage != null)
            {
                imagebox.Source = new BitmapImage(new Uri(selectedImage));

                _exif = new ExifTagCollection(selectedImage);

                foreach (ExifTag tag in _exif)
                    AddTagToList(tag);
                
                for (int i = 0; i < lvExifData.Items.Count; i++)
                {
                    MyExifData foo = (MyExifData)lvExifData.Items[i];
                    if (foo.FieldName == "GPSLatitude")
                    {
                        GPSLatitude = Lat_Long_Deg_To_Dec(foo.Value);
                    }
                    if (foo.FieldName == "GPSLongitude")
                    {
                        GPSLongitude = Lat_Long_Deg_To_Dec(foo.Value);
                    }
                    if (foo.FieldName == "GPSLatitudeRef")
                    {
                        if (foo.Value == "South latitude")
                        {
                            SouthLatitude = true;
                        }
                    }
                    if (foo.FieldName == "GPSLongitudeRef")
                    {
                        if (foo.Value == "West longitude")
                        {
                            WestLongitude = true;
                        }
                    }

                    if (foo.FieldName == "DateTimeOriginal")
                    {
                        getDateTaken(foo.Value);
                    }
                }

                if (SouthLatitude)
                {
                    GPSLatitude = GPSLatitude * -1;
                }

                if (WestLongitude)
                {
                    GPSLongitude = GPSLongitude * -1;
                }

                Latitude.Text = GPSLatitude.ToString();
                Longitude.Text = GPSLongitude.ToString();
                LocationMap.Center = new Microsoft.Maps.MapControl.WPF.Location(Convert.ToDouble(Latitude.Text), Convert.ToDouble(Longitude.Text));
                Pushpin pin = new Pushpin();
                pin.Location = LocationMap.Center;
                // Adds the pushpin to the map.
                LocationMap.Children.Add(pin);

                SouthLatitude = false;
                WestLongitude = false;
            }
            else
            {
                System.Windows.MessageBox.Show("No Image selected");
            }
            
        }

        private void btnMode_Click(object sender, RoutedEventArgs e)
        {
            string MapMode = LocationMap.Mode.ToString();;
            if (MapMode == "Microsoft.Maps.MapControl.WPF.AerialMode" )
            {
                LocationMap.Mode = new RoadMode();
            }
            else
            {
                LocationMap.Mode = new AerialMode(true);
            }
        }

        private void btnRotate_Click(object sender, RoutedEventArgs e)
        {
            Rotate_Image.Angle += 90;
        }

    }
}
