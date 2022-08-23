using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CharityGalaApp
{
    internal class Datenbankverbindung
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;password=;database=CharityGalaApp;");
        public static bool Oeffnen()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fehler beim öffnen der DB" + ex.ToString());
                return false;
            }
        }

        public static void schließen()
        {
            conn.Close();
        }

    }
}
