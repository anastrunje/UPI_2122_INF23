using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kviz
{
    public partial class FormaPrijava : Form
    {
        public static string korisnickoIme;
        SqlConnection con = new SqlConnection();

        public FormaPrijava()
        {
            SqlConnection con = new SqlConnection();
            //Data Source = DESKTOP-RLAI4IM\\SQL2019;; Initial Catalog = STUDENT; Integrated Security = True"
            //ANA "Data Source=DESKTOP-4M9PE5A\\SQLEXPRESS01;Initial Catalog=Prijava;Integrated Security=True"
            //Patricija Data Source=DESKTOP-K3HECM7\MSSQLSERVER01;Initial Catalog=Prijava;Integrated Security=True
            con.ConnectionString = "Data Source=DESKTOP-4M9PE5A\\SQLEXPRESS01;Initial Catalog=Prijava;Integrated Security=True";
            InitializeComponent();
        }

        private void FormaPrijava_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4M9PE5A\\SQLEXPRESS01;Initial Catalog=Prijava;Integrated Security=True");
            con.Open();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            //povezivanje s bazom podataka 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4M9PE5A\\SQLEXPRESS01;Initial Catalog=Prijava;Integrated Security=True";

            con.Open();

            korisnickoIme = korisnickoImeTxt.Text;
            string lozinka = lozinkaTxt.Text;

            //povezivanje s query
            SqlCommand cmd = new SqlCommand("select korisnickoIme,lozinka from tablica where korisnickoIme='"
                + korisnickoIme + "'and lozinka='" + lozinka + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //ako se podaci nalaze u bazi podataka
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Prijava je uspješna.");
                Izbornik izbornik = new Izbornik();
                izbornik.Show();
                this.Hide();

            }
            //ako se podaci ne nalaze u bazi podataka
            else
            {
                MessageBox.Show("Molim Vas provjerite svoje korisnicko ime i lozinku.");
            }
            con.Close();
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
