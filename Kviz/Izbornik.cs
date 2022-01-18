using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Izbornik : Form
    {
        public static bool f;

        public Izbornik()
        {
            InitializeComponent();
        }

        private void btnObjasnjenja_Click(object sender, EventArgs e)
        {
            f = false;
            Predmeti predmeti = new Predmeti();
            this.Hide();
            predmeti.ShowDialog();
            this.Show();

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            f = true;
            Predmeti predmeti = new Predmeti();
            this.Hide();
            predmeti.ShowDialog();
            this.Show();
        }

        private void btnBodovi_Click(object sender, EventArgs e)
        {
            Rang rang = new Rang();
            this.Hide();
            rang.ShowDialog();
            this.Show();
        }
    }
}
