using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class FormaPrijava : Form
    {
        SqlConnection con = new SqlConnection();
        
        public FormaPrijava()
        {
            SqlConnection con = new SqlConnection();
            //Data Source = DESKTOP-RLAI4IM\\SQL2019;; Initial Catalog = STUDENT; Integrated Security = True"
            //ANA "Data Source=DESKTOP-4M9PE5A\\SQLEXPRESS01;Initial Catalog=Prijava;Integrated Security=True"
            con.ConnectionString = "Data Source=DESKTOP-K3HECM7\\MSSQLSERVER01;Initial Catalog=Prijava;Integrated Security=True";
            InitializeComponent();
        }

        private void FormaPrijava_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K3HECM7\\MSSQLSERVER01;Initial Catalog=Prijava;Integrated Security=True");
            con.Open();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-K3HECM7\\MSSQLSERVER01;Initial Catalog=Prijava;Integrated Security=True";
         
            con.Open();

            string korisnickoIme= korisnickoImeTxt.Text;
            string lozinka= lozinkaTxt.Text;

            SqlCommand cmd = new SqlCommand("select korisnickoIme,lozinka from tablica where korisnickoIme='" 
                + korisnickoImeTxt.Text + "'and lozinka='" + lozinkaTxt.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Prijava je uspješna.");
                Izbornik izbornik = new Izbornik();
                izbornik.Show();
                this.Hide();

            }
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

        private void lozinkaTxt_Click(object sender, EventArgs e)
        {
            lozinkaTxt.Text = "";
            lozinkaTxt.ForeColor = Color.Black;

            lozinkaTxt.PasswordChar = '●';

        }
    }
}
