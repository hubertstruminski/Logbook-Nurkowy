using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace LogbookNurkowy
{
    class DatabaseMySql
    {
        static string konfiguracja = "database=nurkowanie;data source=localhost;user=root;password=nations123!;";

        public static void SetUtf8()
        {
            MySqlConnection connection;
            MySqlCommand command;

            using (connection = new MySqlConnection(konfiguracja))
            {
                connection.Open();
                command = new MySqlCommand("SET NAMES utf8", connection);
                command.ExecuteNonQuery();
            }
        }

        public static void ExecuteQuery(string path, DataGridView siatka)
        {
            

            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand zapytanie = new MySqlCommand(path, laczBaze);

            try
            {
                laczBaze.Open();
                MySqlDataAdapter moja = new MySqlDataAdapter();
                moja.SelectCommand = zapytanie;
                DataTable tabela = new DataTable();
                moja.Fill(tabela);

                BindingSource zrodlo = new BindingSource();
                zrodlo.DataSource = tabela;

                siatka.DataSource = zrodlo;
                laczBaze.Close();
            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
            }
        }
    }
}
