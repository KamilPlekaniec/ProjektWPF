﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt.Models
{
    public class SaveToDB
    {
        public static void SaveInfo(string login, string password, string name, string lastname, string age, string joiningdate)
        {
            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektWPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                string query = "INSERT INTO Użytkownik(Loginx, Passwordx, Imię, Nazwisko, Lata, DataDołączenia)"
                    + "VALUES (@Loginx, @Passwordx, @Imię, @Nazwisko, @Lata, @DataDołączenia)";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("Loginx", login);
                command.Parameters.AddWithValue("Passwordx", password);
                command.Parameters.AddWithValue("Imię", name);
                command.Parameters.AddWithValue("Nazwisko", lastname);
                command.Parameters.AddWithValue("Lata", age);
                command.Parameters.AddWithValue("DataDołączenia", joiningdate);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void SelectUsers(string imie, string nazwisko, string wiek, string datadolaczenia)
        {
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjektWPF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConn = new SqlConnection(connection);

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();

                    string query = "SELECT Imię, Nazwisko, Lata, DataDołączenia FROM Użytkownik";
                    SqlCommand command = new SqlCommand(query, sqlConn);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Imię", imie);
                    command.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    command.Parameters.AddWithValue("@Lata", wiek);
                    command.Parameters.AddWithValue("@DataDołączenia", datadolaczenia);

                }
            }
            catch (Exception ex)
            {

                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
