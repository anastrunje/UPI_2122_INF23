using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class PrviMat : Form
    {
        public PrviMat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brojevi pitanja = new Brojevi();
            this.Hide();
            pitanja.ShowDialog();
            this.Show();
        }

        private void btnKviz_Click(object sender, EventArgs e)
        {
            Brojevi brojevi = new Brojevi();

            if (rbtnBrojevi.Checked == true)
            {

                this.Hide();
                brojevi.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Molim Vas odaberite lekciju.");
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
