using System;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Brojevi_Objasnjenje : Form
    {
        public Brojevi_Objasnjenje()
        {
            InitializeComponent();
        }
        int brojac = 0;
        private void Brojevi_Objasnjenje_Load(object sender, EventArgs e)
        {
            brojac++;
            pbxObjasnjenje.Image = Properties.Resources.obj1;
            lblObjasnjenje.Text = "Matematičkim simbolima zapisujemo A∩B = {x : x∈A i x∈B}";
        }

        private void btnSljedeci_Click(object sender, EventArgs e)
        {
            brojac++;
            if (brojac == 2)
            {
                pbxObjasnjenje.Image = Properties.Resources.objasnjenje2;
                lblObjasnjenje.Text = "Matija, Ana, Darija i Nina članovi su istoga odbojkaškog kluba. Oni čine skup O ,O={Matija, Ana, Darija, Nina}.\n" +
                    "Nogometom se bave Ivan, Krešo, Boris i Tvrtko, tj. N={Ivan,Krešo,Boris,Tvrtko}.\nPostoji li u toj skupini osoba koja trenira i nogomet i odbojku?";
            }

        }

        private void btnPrethodni_Click(object sender, EventArgs e)
        {
            brojac--;
            if (brojac == 1)
            {
                pbxObjasnjenje.Image = Properties.Resources.obj1;
                lblObjasnjenje.Text = "Matematičkim simbolima zapisujemo A∩B = {x : x∈A i x∈B}";
            }
        }
    }
}
