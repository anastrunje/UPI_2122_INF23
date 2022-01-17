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
    public partial class Predmeti : Form
    {
        public bool oznaka;

        public Predmeti(bool f)
        {
            InitializeComponent();
            oznaka = f;
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            Razred razred = new Razred(oznaka);
            this.Hide();
            razred.Show();
        }

        private void Predmeti_Load(object sender, EventArgs e)
        {

        }
    }
}
