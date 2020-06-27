using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwnd = new MainWindow();
            mwnd.Show();
            this.Close();
        }

        private void ZalogujBTN_Click(object sender, RoutedEventArgs e)
        {
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektWPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConn = new SqlConnection(connection);

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();

                    string query = "SELECT COUNT(1) FROM Użytkownik WHERE Loginx=@Loginx AND Passwordx=@Passwordx";
                    SqlCommand command = new SqlCommand(query, sqlConn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Loginx", LoginTB.Text);
                    command.Parameters.AddWithValue("@Passwordx", PasswordTB.Text);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        Window3 wnd3 = new Window3();
                        wnd3.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Podany login lub hasło są nieprawidłowe. Spróbuj jeszcze raz!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}

