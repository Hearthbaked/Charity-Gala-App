using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CharityGalaApp
{
    public partial class Hauptfenster : Form
    {
        MySqlConnection conn;
        public Hauptfenster()
        {
            InitializeComponent();
           
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string spenderName = tbName.Text;
            if (spenderName == "") return;
            string s = tbSpende.Text;
            double spendeBetrag = double.Parse(s);

            MySqlCommand cmd = Datenbankverbindung.conn.CreateCommand();
            cmd.CommandText = "insert into spenden(spender, betrag) values(@spender,@betrag)";
            cmd.Parameters.AddWithValue("@spender", spenderName);
            cmd.Parameters.AddWithValue("@betrag", spendeBetrag);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;

            Spende spende = new Spende(id, spenderName, spendeBetrag);
            lbSpender.Items.Add(spende);
        }
        

        private void timerAktualisieren_Tick(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = Datenbankverbindung.conn.CreateCommand();
            cmd.CommandText = "SELECT SUM(betrag) from spenden;";
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                lbSpender.Items.Clear();
                double summe = reader.GetDouble(0);
                pbFortschrittsbalken.Value = (int)summe;
                string gesamtsumme =  Convert.ToString(summe);
                lblGesamtSumme.Text = "Gesamtsumme:"+ gesamtsumme+"€";
                
             
            }
            reader.Close();

            cmd = Datenbankverbindung.conn.CreateCommand();
            cmd.CommandText = "Select * from spenden Order By idSpenden DESC LIMIT 0,5;";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Spende spende = new Spende(reader.GetInt64(0), reader.GetString(1), reader.GetDouble(2));
                lbSpender.Items.Add(spende);
            }
            reader.Close();



        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            if(!Datenbankverbindung.Oeffnen())
            {
                timerAktualisieren.Enabled = false;
                Application.Exit();

            }
            

        }

        private void Hauptfenster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Datenbankverbindung.schließen();
        }
    }
}
