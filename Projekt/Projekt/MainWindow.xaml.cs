using Projekt.Models;
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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogowanieBTN_Click(object sender, RoutedEventArgs e)
        {
            Window2 wnd2 = new Window2();
            wnd2.Show();
            this.Close();
        }

        private void RejestracjaBTN_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd1 = new Window1();
            wnd1.Show();
            this.Close();
        }
    }
}
