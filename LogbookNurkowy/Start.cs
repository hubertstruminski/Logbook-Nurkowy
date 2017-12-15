using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LogbookNurkowy
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            DatabaseMySql.SetUtf8();
            SoundManager.PlayWater();
        }

        private void btnLogbook_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Logbook logbook_nurkowy = new Logbook();
            logbook_nurkowy.Show();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Historia hist = new Historia();
            hist.Show();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Autor autor = new Autor();
            autor.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
