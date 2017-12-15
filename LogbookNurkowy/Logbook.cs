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
    public partial class Logbook : Form
    {
        int id_rekordu;

        public Logbook()
        {
            InitializeComponent();

            SoundManager.PlayWater();

        }

        private void access_gloves()
        {
            if (chbPianka.Checked)
            {
                chbRekawSuche.Enabled = false;
            }
            else
            {
                chbRekawSuche.Enabled = true;
            }
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            if (txtImie.Text == "" || txtNazwisko.Text == "" || txtPImie.Text == "" || txtPNazwisko.Text == "" || txtLokalizacja.Text == "" || txtData.Text == "" || txtCzasWe.Text == "" || txtCzasWy.Text == "" || txtSrGlebokosc.Text == "" || txtMaxGlebokosc.Text == "" || txtWidocznosc.Text == "" || txtAutomat.Text == "" || txtBalast.Text == "" || txtTypNurkowania.Text == "" || txtUwagi.Text == "")
            {
                MessageBox.Show("Uzupełnij dane");
            }
            else if(MessageBox.Show("Czy na pewno chcesz dodać nowy rekord ?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DateTime date;

                date = DateTime.Parse(txtData.Text);
                DatabaseMySql.ExecuteQuery("INSERT INTO nurkowanie.logbook (imie, nazwisko, partner_imie, partner_nazwisko, lokalizacja, data, czas_wejscia, czas_wyjscia, sr_glebokosc, max_glebokosc, widocznosc, automat, ZButl10L, ZButl12L, ZButl15L, ZButl18L, ZButlINNY, suchy_skafander, pianka, wodaSlona, wodaSlodka, wejscieZBrzegu, wejscieZLodki, Balast, rekawice_suche, typ_nurkowania, uwagi) VALUES ('" + txtImie.Text + "', '" + txtNazwisko.Text + "', '" + txtPImie.Text + "', '" + txtPNazwisko.Text + "', '" + txtLokalizacja.Text + "', '" + date.ToString("yyyy-MM-dd") + "', '" + txtCzasWe.Text + "', '" + txtCzasWy.Text + "', '" + txtSrGlebokosc.Text + "', '" + txtMaxGlebokosc.Text + "', '" + txtWidocznosc.Text + "', '" + txtAutomat.Text + "', " + chb10L.Checked + ", " + chb12L.Checked + ", " + chb15L.Checked + ", " + chb18L.Checked + ", '" + txtInnyL.Text + "', " + chbSuchy.Checked + ", " + chbPianka.Checked + ", " + chbWSlona.Checked + ", " + chbWSlodka.Checked + ", " + chbWeBrzeg.Checked + ", " + chbWeLodka.Checked + ", '" + txtBalast.Text + "', " + chbRekawSuche.Checked + ", '" + txtTypNurkowania.Text + "', '" + txtUwagi.Text + "');", dgLogbook);
                MessageBox.Show("Rekord został dodany");
            }
        }

        private void btnLPowrot_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void dgLogbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_rekordu = Convert.ToInt32(dgLogbook.Rows[e.RowIndex].Cells["nurkowanie_id"].Value);
            txtImie.Text = dgLogbook.Rows[e.RowIndex].Cells["imie"].Value.ToString();
            txtNazwisko.Text = dgLogbook.Rows[e.RowIndex].Cells["nazwisko"].Value.ToString();
            txtPImie.Text = dgLogbook.Rows[e.RowIndex].Cells["partner_imie"].Value.ToString();
            txtPNazwisko.Text = dgLogbook.Rows[e.RowIndex].Cells["partner_nazwisko"].Value.ToString();
            txtLokalizacja.Text = dgLogbook.Rows[e.RowIndex].Cells["lokalizacja"].Value.ToString();
            txtData.Text = Convert.ToDateTime(dgLogbook.Rows[e.RowIndex].Cells["data"].Value).ToString("dd-MM-yyyy");
            txtCzasWe.Text = dgLogbook.Rows[e.RowIndex].Cells["czas_wejscia"].Value.ToString();
            txtCzasWy.Text = dgLogbook.Rows[e.RowIndex].Cells["czas_wyjscia"].Value.ToString();
            txtSrGlebokosc.Text = dgLogbook.Rows[e.RowIndex].Cells["sr_glebokosc"].Value.ToString();
            txtMaxGlebokosc.Text = dgLogbook.Rows[e.RowIndex].Cells["max_glebokosc"].Value.ToString();
            txtWidocznosc.Text = dgLogbook.Rows[e.RowIndex].Cells["widocznosc"].Value.ToString();
            txtAutomat.Text = dgLogbook.Rows[e.RowIndex].Cells["automat"].Value.ToString();
            chb10L.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["ZButl10L"].Value);
            chb12L.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["ZButl12L"].Value);
            chb15L.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["ZButl15L"].Value);
            chb18L.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["ZButl18L"].Value);
            txtInnyL.Text = dgLogbook.Rows[e.RowIndex].Cells["ZButlINNY"].Value.ToString();
            chbSuchy.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["suchy_skafander"].Value);
            chbPianka.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["pianka"].Value);
            chbWSlodka.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["wodaSlodka"].Value);
            chbWSlona.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["wodaSlona"].Value);
            chbWeBrzeg.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["wejscieZBrzegu"].Value);
            chbWeLodka.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["wejscieZLodki"].Value);
            txtBalast.Text = dgLogbook.Rows[e.RowIndex].Cells["balast"].Value.ToString();
            chbRekawSuche.Checked = Convert.ToBoolean(dgLogbook.Rows[e.RowIndex].Cells["rekawice_suche"].Value);
            txtTypNurkowania.Text = dgLogbook.Rows[e.RowIndex].Cells["typ_nurkowania"].Value.ToString();
            txtUwagi.Text = dgLogbook.Rows[e.RowIndex].Cells["uwagi"].Value.ToString();

            this.btnUsun.Enabled = true;
            this.btnModyfikuj.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            DatabaseMySql.ExecuteQuery("SELECT * FROM nurkowanie.logbook;", dgLogbook);

            dgLogbook.Columns[0].Visible = false;

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();

            if(id_rekordu == 1)
            {
                MessageBox.Show("Nie można usunąć pierwszego rekordu");
            }
            else
            {
                if (MessageBox.Show("Czy usunąć wybrany rekord ?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseMySql.ExecuteQuery("DELETE FROM nurkowanie.logbook WHERE nurkowanie_id = " + id_rekordu + ";", dgLogbook);

                    MessageBox.Show("Usunąłeś rekord");
                }
            }
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();

            if (MessageBox.Show("Czy na pewno chcesz zmodyfikować wybrany rekord ?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DatabaseMySql.ExecuteQuery("UPDATE nurkowanie.logbook SET imie = '" + txtImie.Text + "', nazwisko = '" + txtNazwisko.Text + "', partner_imie = '" + txtPImie.Text + "', partner_nazwisko = '" + txtPNazwisko.Text + "', lokalizacja = '" + txtLokalizacja.Text + "', data = '" + txtData.Text + "', czas_wejscia = '" + txtCzasWe.Text + "', czas_wyjscia = '" + txtCzasWy.Text + "', sr_glebokosc = '" + txtSrGlebokosc.Text + "', max_glebokosc = '" + txtMaxGlebokosc.Text + "', widocznosc = '" + txtWidocznosc.Text + "', automat = '" + txtAutomat.Text + "', ZButl10L = " + chb10L.Checked + ", ZButl12L = " + chb12L.Checked + ", ZButl15L = " + chb15L.Checked + ", ZButl18L = " + chb18L.Checked + ", ZButlINNY = '" + txtInnyL.Text + "', suchy_skafander = " + chbSuchy.Checked + ", pianka = " + chbPianka.Checked + ", wodaSlona = " + chbWSlona.Checked + ", wodaSlodka = " + chbWSlodka.Checked + ", wejscieZBrzegu = " + chbWeBrzeg.Checked + ", wejscieZLodki = " + chbWeLodka.Checked + ", balast = '" + txtBalast.Text + "', rekawice_suche = " + chbRekawSuche.Checked + ", typ_nurkowania = '" + txtTypNurkowania.Text + "', uwagi = '" + txtUwagi.Text + "' WHERE nurkowanie_id = " + id_rekordu + ";", dgLogbook);
                MessageBox.Show("Rekord został zmodyfikowany");
            }
        }
    }
}
