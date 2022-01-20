using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Kraj : Form
    {
        public Kraj()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRang_Click(object sender, EventArgs e)
        {
            Rang rang = new Rang();
            this.Hide();
            rang.Show();
        }

        private void Kraj_Load(object sender, EventArgs e)
        {
            //ispis broja ostvarenih bodova u label
            if (Brojevi.bodovi == 1)
                lblBod.Text = Brojevi.bodovi.ToString() + " bod";
            else if (Brojevi.bodovi == 5)
                lblBod.Text = Brojevi.bodovi.ToString() + " bodova";
            else
                lblBod.Text = Brojevi.bodovi.ToString() + " boda";
        }
    }
}
