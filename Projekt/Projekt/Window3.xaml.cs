using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void LogoutBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mnwd = new MainWindow();
            mnwd.Show();
            this.Close();
        }

        private void ChangeImageBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"Programowanie IV\ProjektProgramowanieWPF\Projekt";
            open.Filter = "Image files(*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg;";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = System.IO.Path.GetDirectoryName(open.FileName);
                get_Images(path);
            }
        }
        private void get_Images(string folder_Path)
        {
            if (folder_Path == "") return;
            try
            {
                DirectoryInfo folder = new DirectoryInfo(folder_Path);
                if (folder.Exists)
                {
                    foreach (FileInfo fileInfo in folder.GetFiles())
                    {
                        if (".jpg;|.jpeg|.png".Contains(fileInfo.Extension.ToLower()))
                        {
                            string sDate = fileInfo.LastWriteTime.ToString("dd-MM-yyyy");
                            add_Image(fileInfo.FullName);
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void add_Image(string Image_with_path)
        {
            Image newImage = new Image();

            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(Image_with_path, UriKind.Absolute);
            src.EndInit();
            newImage.Source = src;

            newImage.Stretch = Stretch.Uniform;
            newImage.VerticalAlignment = VerticalAlignment.Center;
            MyImage.Children.Add(newImage);
        }

        private void StatBTN_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void WpisBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StatOtherBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OtherUserBTN_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
