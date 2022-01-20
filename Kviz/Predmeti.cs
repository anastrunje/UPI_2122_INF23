using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Predmeti : Form
    {


        public Predmeti()
        {
            InitializeComponent();
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            Razred razred = new Razred();
            this.Hide();
            razred.ShowDialog();
            this.Show();
        }
    }
}
