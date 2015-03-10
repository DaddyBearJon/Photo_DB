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
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhotoApp
{
    /// <summary>
    /// Interaction logic for AddFolder.xaml
    /// </summary>
    public partial class AddFolder : Window
    {
        bool Auto;
        bool Man;
        string subFolderName;
        string pathString;
        
        public AddFolder()
        {
            InitializeComponent();
        }

        private bool createFolder(string pathString)
        {
            if (!Directory.Exists(pathString))
            {
                System.IO.Directory.CreateDirectory(pathString);
                return true;
            }
            else
            {
                return true;
            }
        }

        private void createManyFolders(int numFolders, string pathString)
        {
            string fullPathString;
            for (int i = 1; i <= numFolders; i++)
            {
                fullPathString = @"" + pathString + @"\" + i;
                bool tempBool = createFolder(fullPathString);
            }
        }

        private void createDays(string pathString, string month, string year)
        {
            int iYear = Convert.ToInt32(year);          
            string fullPathString;
            
            fullPathString = @"" + pathString + @"\" + month;
            switch (month)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    createManyFolders(31, fullPathString);
                    break;

                case "April":
                case "June":
                case "September":
                case "November":
                    createManyFolders(30, fullPathString);
                    break;
                case "February":
                    if ((iYear % 4 == 0) & (!(iYear % 100 == 0) || (iYear % 400 == 0)))
                    {
                        createManyFolders(29, fullPathString);
                        break;
                    }
                    else
                    {
                        createManyFolders(28, fullPathString);
                        break;
                    }
                    
            }
                

        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
            }
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Man)
            {
                // Specify a name for your top-level folder. 
                subFolderName = @"\" + txtFolder.Text;
                try
                {
                    // To create a string that specifies the path to a subfolder under your  
                    // top-level folder, add a name for the subfolder to folderName. 
                    pathString = @"" + txtPath.Text + subFolderName;
                    bool manCreateFolder = createFolder(pathString);
                    if (manCreateFolder)
                    {
                        // Create the subfolder. You can verify in File Explorer that you have this 
                        System.IO.Directory.CreateDirectory(pathString);
                        if (Directory.Exists(pathString))
                        {
                            System.Windows.MessageBox.Show("Folder Created");
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Folder Already Exists");
                    }

                }

                catch (Exception err)
                {
                    Console.WriteLine("{0} Exception caught.", err);
                }
            }
            else
            {
                subFolderName = @"\" + txtYear.Text;
                try
                {
                    // To create a string that specifies the path to a subfolder under your  
                    // top-level folder, add a name for the subfolder to folderName. 
                    pathString = @"" + txtPath.Text + subFolderName;
                    bool createmonths = createFolder(pathString);
                    if (createmonths)
                    {
                        if (Directory.Exists(pathString))
                        {
                            string monthPathString;
                            string monthFolder;
                            for (int i = 1; i <= 12; i++)
                            {
                                switch (i)
                                {
                                    case 1:
                                        monthFolder = "January";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool January = createFolder(monthPathString);
                                        if (January)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 2:
                                        monthFolder = "February";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool February = createFolder(monthPathString);
                                        if (February)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 3:
                                        monthFolder = "March";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool March = createFolder(monthPathString);
                                        if (March)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 4:
                                        monthFolder = "April";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool April = createFolder(monthPathString);
                                        if (April)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 5:
                                        monthFolder = "May";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool May = createFolder(monthPathString);
                                        if (May)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 6:
                                        monthFolder = "June";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool June = createFolder(monthPathString);
                                        break;
                                    case 7:
                                        monthFolder = "July";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool July = createFolder(monthPathString);
                                        if (July)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 8:
                                        monthFolder = "August";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool August = createFolder(monthPathString);
                                        if (August)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 9:
                                        monthFolder = "September";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool September = createFolder(monthPathString);
                                        if (September)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 10:
                                        monthFolder = "October";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool October = createFolder(monthPathString);
                                        if (October)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 11:
                                        monthFolder = "November";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool November = createFolder(monthPathString);
                                        if (November)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    case 12:
                                        monthFolder = "December";
                                        monthPathString = @"" + pathString + @"\" + monthFolder;
                                        bool December = createFolder(monthPathString);
                                        if (December)
                                        {
                                            createDays(pathString, monthFolder, txtYear.Text);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Cannot Create Folder");
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Folder Already Exists");
                    }

                    
                        System.Windows.MessageBox.Show("Done!");
                    
                
                }

                catch (Exception err)
                {
                    Console.WriteLine("{0} Exception caught.", err);
                }
            }
            
            
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rbtnMan_Checked(object sender, RoutedEventArgs e)
        {
            Auto = false;
            Man = true;
        }

        private void rbtnAuto_Checked(object sender, RoutedEventArgs e)
        {
            Man = false;
            Auto = true;
        }

       
    }
}
