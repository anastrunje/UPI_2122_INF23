using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kviz
{
    public partial class Brojevi : Form
    {
        public Brojevi()
        {
            InitializeComponent();
        }

        int brojPitanja = 0;
        int bodovi = 0;

        private void Brojevi_Load(object sender, EventArgs e)
        {
            btnProvjeri.Enabled = true;
            btnProvjeri.BackColor = Color.Green;
            btnSljedece.Enabled = false;
            btnSljedece.BackColor = Color.Red;
            brojPitanja++;

            /*if (brojPitanja == 1)
            {
                label1.Text = "Koji je broj označen na ovom brojevnom pravcu?";
                pbxPitanje.Image = Properties.Resources.brojevnipravac1;
                rbtTreci.Text = "-7";
                rbtPrvi.Text = "7/2";
                rbtDrugi.Text = "6/5";
                rbtCetvrti.Text = "-2.5";
                lblBrojzadatka.Text = "1.Zadatak";
            }
            else if (brojPitanja == 2)
            {
                label1.Text = "Koji je broj označen na ovom brojevnom pravcu?";
                pbxPitanje.Image = Properties.Resources.brojevnipravac2;
                rbtTreci.Text = "-2.5";
                rbtPrvi.Text = "6/5";
                rbtDrugi.Text = "7/2";
                rbtCetvrti.Text = "6";
                lblBrojzadatka.Text = "2.Zadatak";
            }
            else if (brojPitanja == 3)
            {
                label1.Text = "Odaberi točan odgovor.";
                pbxPitanje.Image = Properties.Resources.brojevi;
                rbtTreci.Text = "0";
                rbtPrvi.Text = "4/5";
                rbtDrugi.Text = "0.8";
                rbtCetvrti.Text = "2/3";
                lblBrojzadatka.Text = "3.Zadatak";
            }
            else if (brojPitanja == 4)
            {
                label1.Text = "Odredite skup A.";
                pbxPitanje.Image = Properties.Resources.brojevi3;
                rbtTreci.Text = "{3, 6, 9, 12, 15, 18}";
                rbtPrvi.Text = "{3, 9, 18}";
                rbtDrugi.Text = "{1,3}";
                rbtCetvrti.Text = "{9, 18}";
                lblBrojzadatka.Text = "4.Zadatak";
            }
            else if (brojPitanja == 5)
            {
                label1.Text = "Odredite skup B";
                pbxPitanje.Image = Properties.Resources.brojevi4;
                rbtTreci.Text = "{2, 4, 6, 8, 10, 12, 14, 16, 18}";
                rbtPrvi.Text = "{2, 4, 16}";
                rbtDrugi.Text = "{1, 2}";
                rbtCetvrti.Text = "{2, 4, 6, 10}";
                lblBrojzadatka.Text = "5.Zadatak";
            }*/

            int[] arr = { 0, 1 }; //{ 0, 1, 2, 3, 4 };
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            string[] pitanja = File.ReadAllLines("proba.txt");
            string[] pitanje;

            if (brojPitanja==1)
            {
                pitanje = pitanja[arr[brojPitanja - 1]].Split(';');
                lblPitanje.Text = pitanje[0];
                //pbxPitanje.Image = Image.FromFile(pitanje[1]);
            }

        }
        private void btnSljedece_Click(object sender, EventArgs e)
        {
            btnProvjeri.Enabled = true;
            btnProvjeri.BackColor = Color.Green;
            btnSljedece.Enabled = false;
            btnSljedece.BackColor = Color.Red;

            brojPitanja++;
            if (brojPitanja == 1)
            {
                lblPitanje.Text = "Koji je broj označen na ovom brojevnom pravcu?";
                pbxPitanje.Image = Properties.Resources.brojevnipravac1;
                rbtTreci.Text = "-7";
                rbtPrvi.Text = "7/2";
                rbtDrugi.Text = "6/5";
                rbtCetvrti.Text = "-2.5";
                lblBrojzadatka.Text = "1.Zadatak";
            }
            else if (brojPitanja == 2)
            {
                lblPitanje.Text = "Koji je broj označen na ovom brojevnom pravcu?";
                pbxPitanje.Image = Properties.Resources.brojevnipravac2;
                rbtTreci.Text = "-2.5";
                rbtPrvi.Text = "6/5";
                rbtDrugi.Text = "7/2";
                rbtCetvrti.Text = "6";
                lblBrojzadatka.Text = "2.Zadatak";
            }
            else if (brojPitanja == 3)
            {
                lblPitanje.Text = "Odaberi točan odgovor.";
                pbxPitanje.Image = Properties.Resources.brojevi;
                rbtTreci.Text = "0";
                rbtPrvi.Text = "4/5";
                rbtDrugi.Text = "0.8";
                rbtCetvrti.Text = "2/3";
                lblBrojzadatka.Text = "3.Zadatak";
            }
            else if (brojPitanja == 4)
            {
                lblPitanje.Text = "Odredite skup A.";
                pbxPitanje.Image = Properties.Resources.brojevi3;
                rbtTreci.Text = "{3, 6, 9, 12, 15, 18}";
                rbtPrvi.Text = "{3, 9, 18}";
                rbtDrugi.Text = "{1,3}";
                rbtCetvrti.Text = "{9, 18}";
                lblBrojzadatka.Text = "4.Zadatak";
            }
            else if (brojPitanja == 5)
            {
                lblPitanje.Text = "Odredite skup B";
                pbxPitanje.Image = Properties.Resources.brojevi4;
                rbtTreci.Text = "{2, 4, 6, 8, 10, 12, 14, 16, 18}";
                rbtPrvi.Text = "{2, 4, 16}";
                rbtDrugi.Text = "{1, 2}";
                rbtCetvrti.Text = "{2, 4, 6, 10}";
                lblBrojzadatka.Text = "5.Zadatak";
            }
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            btnProvjeri.Enabled = false;
            btnProvjeri.BackColor = Color.Red;
            btnSljedece.Enabled = true;
            btnSljedece.BackColor = Color.Green;

            if(brojPitanja==1)
            {
                if (rbtPrvi.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova" + bodovi;
            }
            if (brojPitanja == 2)
            {
                if (rbtDrugi.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova" + bodovi;
            }
            if (brojPitanja == 3)
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova" + bodovi;
            }
            if (brojPitanja == 4)
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova" + bodovi;
            }
            if (brojPitanja == 5)
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova" + bodovi;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult odg = MessageBox.Show("Jeste li sigurni da želite odustati?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (odg.ToString() == "Yes")
            {
                PrviMat prvimat = new PrviMat();
                prvimat.Show();
                this.Hide();
            }
              
            
        }
    }
}

