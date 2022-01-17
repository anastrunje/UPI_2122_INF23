using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            pitanja.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKviz_Click(object sender, EventArgs e)
        {
            Brojevi brojevi = new Brojevi();
            Algebarski algebarski = new Algebarski();
            Potencije potencije = new Potencije();

            if (rbtnBrojevi.Checked == true)
            {
                brojevi.Show();
                this.Hide();
            }
            else if (rbtnPotencije.Checked == true)
            {
                potencije.Show();
                this.Hide();
            }
            //i tako za svaku;danas cu rijesiti ove dvi
            else
            {
                MessageBox.Show("Molim Vas odaberite lekciju.");
            }

           
        }

        private void PrviMat_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
