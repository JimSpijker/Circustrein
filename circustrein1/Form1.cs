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

namespace circustrein1
{
    public partial class Form1 : Form
    {
        Trein trein = new Trein();
        public Form1()
        {
            InitializeComponent();
        }

        private void btToevoegen_Click(object sender, EventArgs e)
        {
            voegToe();
        }

        private void voegToe()
        {
            if (tbNaam.Text == null || cbGrootte.SelectedIndex == -1 || cbSoort.SelectedIndex == -1)
            {
                MessageBox.Show("Vul alle opties in");
            }
            else
            {
                string Naam = tbNaam.Text;
                Dier.grootte Grootte;
                if (cbGrootte.SelectedIndex == 0) { Grootte = Dier.grootte.klein; }
                else if (cbGrootte.SelectedIndex == 1) { Grootte = Dier.grootte.medium; }
                else { Grootte = Dier.grootte.groot; }
                Dier.soort Soort;
                if (cbSoort.SelectedIndex == 0) { Soort = Dier.soort.Herbivoor; }
                else { Soort = Dier.soort.Carnivoor; }
                Dier dier = new Dier(Naam, Soort, Grootte);
                if (trein.addDier(dier))
                {
                    lbDieren.Items.Add(dier);
                }
            }
        }

        private void Save()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    int number = 1;
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        foreach (Wagon wagon in trein.Wagons)
                        {
                            sw.WriteLine("Wagon " + number + ":");
                            foreach (Dier dier in wagon.Dieren)
                            {
                                sw.WriteLine(dier.ToString());
                            }
                            sw.WriteLine("");
                            number++;
                        }
                    }

                }

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}
