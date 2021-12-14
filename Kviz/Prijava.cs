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
        public FormaPrijava()
        {
            InitializeComponent();
        }



        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            string korisnik = " ";
            string lozinka = " ";
            string vezaString = ConfigurationManager.ConnectionStrings["Kviz.Properties.Settings.PrijavaBPConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(vezaString);
            veza.Open();
            SqlCommand cmd = new SqlCommand("select * from TablicaPrijava where KorisnickoIme= ' " + korisnickoImeTxt.Text.ToString() + " ' and Lozinka= ' " + lozinkaTxt.Text.ToString()+"'", veza);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                korisnik = reader.GetString(1);
                lozinka = reader.GetString(2);
            }
            Izbornik izbornik = new Izbornik();
            izbornik.Show();
            
        }
    }
}
