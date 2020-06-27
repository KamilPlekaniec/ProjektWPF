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
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        
        private void SubmitBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var login = LoginTB.Text;
                var password = PasswordTB.Text;
                var name = NameTB.Text;
                var lastname = LastNameTB.Text;
                var age = AgeTB.Text;
                var joiningdate = DataLB.Content;


                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Pole 'Podaj swoje imię' nie może być puste. Proszę wpisz swoje imię.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                else if (string.IsNullOrEmpty(lastname))
                {
                    MessageBox.Show("Pole 'Podaj swoje nazwisko' nie może być puste. Proszę wpisz swoje nazwisko.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(age))
                {
                    MessageBox.Show("Pole 'Podaj swój wiek' nie może być puste. Proszę wpisz swój wiek.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    SaveToDB.SaveInfo(login, password, name, lastname, age, joiningdate.ToString());
                    MessageBox.Show($"Pomyślnie zarejestrowano użytkownika {login}! Zapisano go w bazie danych!", "Powodzenie", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainWindow mwnd = new MainWindow();
                    mwnd.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);

                MessageBox.Show("Coś poszło nie tak, spróbuj ponownie później.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwnd = new MainWindow();
            mwnd.Show();
            this.Close();
        }
    }
}
