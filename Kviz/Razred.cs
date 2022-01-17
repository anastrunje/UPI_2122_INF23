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
    public partial class Razred : Form
    {
        public bool ozn;
        public Razred(bool f)
        {
            InitializeComponent();
            ozn = f;
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if (ozn)
            {
                PrviMat prviMat = new PrviMat();
                this.Hide();
                prviMat.Show();
            }
            else
            {
                PrviMatObj prviMatObj = new PrviMatObj();
                this.Hide();
                prviMatObj.Show();
            }
            
        }

        private void Razred_Load(object sender, EventArgs e)
        {

        }
    }
}
