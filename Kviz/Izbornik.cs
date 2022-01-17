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
    public partial class Izbornik : Form
    {
        public bool f;

        public Izbornik()
        {
            InitializeComponent();
        }

        private void btnObjasnjenja_Click(object sender, EventArgs e)
        {
            f = false;
            Predmeti predmeti = new Predmeti(f);
            this.Hide();
            predmeti.Show();

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            f = true;
            Predmeti predmeti = new Predmeti(f);
            this.Hide();
            predmeti.Show();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {

        }
    }
}
