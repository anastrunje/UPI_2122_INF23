using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Rang : Form
    {
        //radi silazni bubble sort po bodovima
        private List<string[]> BubbleSort(List<string[]> rows)
        {
            string[] prvi;
            string[] drugi;
            string[] t;
            for (int i = 0; i < rows.Count - 1; i++)
            {
                prvi = rows[i];
                for (int j = i + 1; j < rows.Count; j++)
                {
                    drugi = rows[j];
                    if (int.Parse(drugi[1]) > int.Parse(prvi[1]))
                    {
                        t = drugi;
                        drugi = prvi;
                        prvi = t;

                        rows[i] = prvi;
                        rows[j] = drugi;
                    }
                }
            }

            return rows;
        }

        public Rang()
        {
            InitializeComponent();
        }

        private void Rang_Load(object sender, EventArgs e)
        {
            string[] redovi = File.ReadAllLines("rang_lista.txt"); //dohvaca podatke iz .txt po redovima
            List<string[]> red = new List<string[]>(); //lista u kojoj ce se appendati "splitane" linije, tj. username i broj bodova zasebno

            foreach (string split in redovi)
                red.Add(split.Split(';'));

            red = BubbleSort(red);

            //ispis poredane liste u richtextbox
            string[] r;
            for (int i = 0; i < redovi.Length; i++)
            {
                r = red[i];
                rtbRang.AppendText(String.Format("{0}. {1}: {2}\n", i + 1, r[0].ToString(), r[1].ToString()));
            }
        }
    }
}
