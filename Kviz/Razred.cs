using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Razred : Form
    {
        public Razred()
        {
            InitializeComponent();
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if (Izbornik.f)
            {
                PrviMat prviMat = new PrviMat();
                this.Hide();
                prviMat.ShowDialog();
                this.Show();
            }
            else
            {
                PrviMatObj prviMatObj = new PrviMatObj();
                this.Hide();
                prviMatObj.ShowDialog();
                this.Show();
            }
        }
    }
}
