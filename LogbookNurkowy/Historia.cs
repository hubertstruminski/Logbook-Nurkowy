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

namespace LogbookNurkowy
{
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();

            SoundManager.PlayWater();
        }

        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();

            DatabaseMySql.ExecuteQuery("SELECT * FROM nurkowanie.logbook", dgHistoria);

            dgHistoria.Columns[0].Visible = false;
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void btnHWyszukaj_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();

            DatabaseMySql.ExecuteQuery("SELECT * FROM nurkowanie.logbook WHERE CONCAT (imie, nazwisko, partner_imie, partner_nazwisko, lokalizacja, data, sr_glebokosc, max_glebokosc, automat, typ_nurkowania, uwagi) LIKE '%"+ txtWyszukaj.Text +"%';", dgHistoria);
        }

    }
}
