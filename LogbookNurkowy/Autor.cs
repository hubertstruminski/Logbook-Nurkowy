using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogbookNurkowy
{
    public partial class Autor : Form
    {
        public Autor()
        {
            InitializeComponent();

            SoundManager.PlayWater();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            SoundManager.PlayButton();
            this.Hide();
            Start start = new Start();
            start.Show();
        }
    }
}
