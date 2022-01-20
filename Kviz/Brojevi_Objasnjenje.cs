using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Brojevi_Objasnjenje : Form
    {
        private void GenerirajObjasnjenja(Image slikeobj, string[] objasni)
        {
            //objasnjenje je sastavljeno od teksta objasnjenja i slike
            lblObjasnjenje.Text = objasni[0];
            pbxObjasnjenje.Image = slikeobj;
        }

        public Brojevi_Objasnjenje()
        {
            InitializeComponent();
        }

        int brojac = 0; //brojac stranice
        int[] arr1= { 0, 1, 2 }; //niz broja stranice

        Image[] slikeobj = { Properties.Resources.obj1, Properties.Resources.objasnjenje2, Properties.Resources.brojeviobj3 }; //niz slika
        
        string[] objasnjenja = File.ReadAllLines("objasnjenje.txt"); //iščitavanje pitanja iz .txt filea u array
        string[] objasni;

        private void Brojevi_Objasnjenje_Load(object sender, EventArgs e)
        {
            brojac++;
            Image[] slikeobj = { Properties.Resources.obj1, Properties.Resources.objasnjenje2, Properties.Resources.brojeviobj3 }; 

            objasni = objasnjenja[arr1[brojac - 1]].Split(';');

            GenerirajObjasnjenja(slikeobj[arr1[brojac - 1]], objasni);
        }

        private void btnSljedeci_Click(object sender, EventArgs e)
        {
            brojac++;
            if (brojac== 1 || brojac <=3)
            {
                objasni = objasnjenja[arr1[brojac - 1]].Split(';');
                objasni = objasni.Select(x => x.Replace(".", ".\n")).ToArray(); //prijelaz u novi red prilikom objasnjavanja
                GenerirajObjasnjenja(slikeobj[arr1[brojac - 1]], objasni);
            }
            else
            {
                Izbornik izbornik = new Izbornik();
                izbornik.ShowDialog();
                this.Close();
            }

        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            brojac--;
            if (brojac== 3 || brojac>= 1)
            {
                objasni = objasnjenja[arr1[brojac - 1]].Split(';');
                objasni = objasni.Select(x => x.Replace(".", ".\n")).ToArray(); //prijelaz u novi red prilikom objasnjavanja
                GenerirajObjasnjenja(slikeobj[arr1[brojac - 1]], objasni);
            }
            else
            {
                Izbornik izbornik = new Izbornik();
                izbornik.ShowDialog();
                this.Hide();
            }
       

            
             

        }
    }
}
