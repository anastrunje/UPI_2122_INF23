using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Brojevi : Form
    {
        private void GenerirajPitanja(Image slika, string[] pitanje, int redni_br)
        {
            //pitanje je sastavljeno kao: tekst pitanja, prvi odg., drugi odg., treci odg., cetvrti odg.
            lblPitanje.Text = pitanje[0];
            pbxPitanje.Image = slika;
            rbtTreci.Text = pitanje[1];
            rbtPrvi.Text = pitanje[2];
            rbtDrugi.Text = pitanje[3];
            rbtCetvrti.Text = pitanje[4];
            lblBrojzadatka.Text = String.Format("{0}. Zadatak", redni_br.ToString());
        }

        public Brojevi()
        {
            InitializeComponent();
        }

        int brojPitanja = 0;
        public static int bodovi = 0;
        int[] arr = { 0, 1, 2, 3, 4 }; //za random shufflanje poretka pitanja

        //slike koje se učitavaju u picturebox u istom poretku kao i pitanja u .txt fileu
        Image[] slike = { Properties.Resources.brojevnipravac1, Properties.Resources.brojevnipravac2, Properties.Resources.brojevi, Properties.Resources.brojevi3, Properties.Resources.brojevi4 };
        string[] pitanja = File.ReadAllLines("proba.txt"); //iščitavanje pitanja iz .txt filea u array
        string[] pitanje;

        private void Brojevi_Load(object sender, EventArgs e)
        {
            lblBodovi.Text = "";

            //mijenjanje boja buttona ovisno o tome može li se pritisnuti
            btnProvjeri.Enabled = true;
            btnProvjeri.BackColor = Color.Green;
            btnSljedece.Enabled = false;
            btnSljedece.BackColor = Color.Red;

            brojPitanja++;

            /*pošto ne želimo ponavljanje pitanja, napravljen je array iste veličine kao i broj pitanja
            te će se brojevi u arrayu koristiti za generiranje određenog pitanja.
            npr. ako se shuffle-a iz [0,1,2,3,4] u [3,0,2,4,1], onda ćemo za indeks 1. pitanja koje 
            je generirano koristiti arr[0](=3), a ne samo 0*/
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            pitanje = pitanja[arr[brojPitanja - 1]].Split(';');

            GenerirajPitanja(slike[arr[brojPitanja - 1]], pitanje, brojPitanja);

        }
        private void btnSljedece_Click(object sender, EventArgs e)
        {
            btnProvjeri.Enabled = true;
            btnProvjeri.BackColor = Color.Green;
            btnSljedece.Enabled = false;
            btnSljedece.BackColor = Color.Red;

            brojPitanja++;

            if (brojPitanja < 6)
            {
                pitanje = pitanja[arr[brojPitanja - 1]].Split(';');
                GenerirajPitanja(slike[arr[brojPitanja - 1]], pitanje, brojPitanja);
            }
            else
            {
                string unos = FormaPrijava.korisnickoIme + ";" + bodovi;
                File.AppendAllText("rang_lista.txt", unos + Environment.NewLine);

                Kraj kraj = new Kraj();
                this.Hide();
                kraj.ShowDialog();
            }
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            btnProvjeri.Enabled = false;
            btnProvjeri.BackColor = Color.Red;
            btnSljedece.Enabled = true;
            btnSljedece.BackColor = Color.Green;

            //provjera točnosti odgovora
            if (lblPitanje.Text == "Koji je broj označen na brojevnom pravcu?")
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova: " + bodovi;
            }
            else if (lblPitanje.Text == "Koji je broj označen na ovom brojevnom pravcu?")
            {
                if (rbtDrugi.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova: " + bodovi;
            }
            else if (lblPitanje.Text == "Odaberi točan odgovor.")
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova: " + bodovi;
            }
            else if (lblPitanje.Text == "Odredite skup A.")
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova: " + bodovi;
            }
            else if (lblPitanje.Text == "Odredite skup B.")
            {
                if (rbtTreci.Checked)
                    bodovi++;
                lblBodovi.Text = "Broj bodova: " + bodovi;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult odg = MessageBox.Show("Jeste li sigurni da želite odustati?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (odg.ToString() == "Yes")
            {
                PrviMat prvimat = new PrviMat();
                this.Hide();
                prvimat.ShowDialog();
            }
        }
    }
}

