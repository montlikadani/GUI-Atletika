using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atletikaGUI {
    public partial class Form1 : Form {

        private readonly List<Versenyzo> versenyzok = new List<Versenyzo>();
        private readonly MySqlConnection connection;

        public Form1() {
            InitializeComponent();

            (connection = new MySqlConnection()).ConnectionString = "server=localhost;uid=root;database=atletikavb2017;";

            try {
                connection.Open();
            } catch (Exception ex) {
                MessageBox.Show("Nem lehetett kapcsolatot létesíteni az adatbázissal.", ex.Message);
                Environment.Exit(0);
                return;
            }

            using (MySqlDataReader reader = new MySqlCommand(
                    "select Versenyszam, Nem, VersenyzoNev, Eredmeny, Csucs, Helyezes, NemzetId, Nemzet from versenyekszamok join nemzetek on versenyekszamok.NemzetKod = nemzetek.NemzetId;",
                    connection).ExecuteReader()) {
                while (reader.Read()) {
                    string versenySzam = reader.GetString("Versenyszam");

                    versenyzok.Add(new Versenyzo(versenySzam, reader.GetString("VersenyzoNev"), reader.GetString("Eredmeny"),
                        reader.IsDBNull(4) ? null : reader.GetString("Csucs"),
                        reader.GetChar("Nem"), reader.GetChar("NemzetId"), reader.GetInt32("Helyezes"), reader.GetString("Nemzet")));

                    if (!versenyszamok.Items.Contains(versenySzam)) {
                        versenyszamok.Items.Add(versenySzam);
                    }
                }
            }
        }

        private void aranyosNemzetek_Click(object sender, EventArgs e) {
            foreach (Versenyzo versenyzo in versenyzok) {
                if (versenyzo.Neme == 'F' && versenyzo.Helyezes != 0 && !aranyermetSzerzett.Items.Contains(versenyzo.Nemzet)) {
                    aranyermetSzerzett.Items.Add(versenyzo.Nemzet);
                }
            }

            aranyosNemzetek.Visible = false;
        }

        private void kereses_Click(object sender, EventArgs e) {
            object selectedItem = versenyszamok.SelectedItem;

            if (selectedItem is null) {
                MessageBox.Show("Nem választott ki versenyszámot!", "Hiba", MessageBoxButtons.OK);
                return;
            }

            decimal value = ermesHelyezes.Value;

            if (value > 3 || value < 1) {
                MessageBox.Show("Csak érmes helyezéseket tartalmaz a statisztika!", "Hiba", MessageBoxButtons.OK);
                return;
            }

            foreach (Versenyzo versenyzo in versenyzok) {
                if (versenyzo.Helyezes == value && selectedItem.Equals(versenyzo.VersenySzam)) {
                    versenyzoNev.Text = "neve:   " + versenyzo.VersenyzoNev;
                    versenyzoEredmenye.Text = "eredménye:   " + versenyzo.Eredmeny;
                    versenyzoNemzete.Text = "nemzete:   " + versenyzo.Nemzet;
                    break;
                }
            }
        }
    }
}
