using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class PrviMatObj : Form
    {
        public PrviMatObj()
        {
            InitializeComponent();
        }

        private void btnObj_Click(object sender, EventArgs e)
        {
            Brojevi_Objasnjenje brobj = new Brojevi_Objasnjenje();
            this.Hide();
            brobj.ShowDialog();
            this.Show();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
