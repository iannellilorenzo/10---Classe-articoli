using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        public Articolo[] articoli;
        public Articolo[] sorted;
        public int num;

        public Form1()
        {
            InitializeComponent();
            articoli = new Articolo[100];
            sorted = new Articolo[100];
            articoli[0] = new Articolo(); // head
            num = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AggBut_Click(object sender, EventArgs e)
        {
            if (!ArtAlimRadio.Checked && !ArtAlimFreRadio.Checked && !ArtNAlimRadio.Checked)
            {
                MessageBox.Show("Selezionare una delle possibili categorie di prodotto.");
                return;
            }

            if (String.IsNullOrEmpty(Desc.Text))
            {
                MessageBox.Show("Inserire un nome o descrizione valido.");
                return;
            }

            if (!double.TryParse(PrezzoUnit.Text, out double prezzo) || PrezzoUnit.Text == "0" || prezzo < 0 || String.IsNullOrEmpty(PrezzoUnit.Text))
            {
                MessageBox.Show("Inserire un prezzo valido.");
                return;
            }

            if (ArtAlimRadio.Checked)
            {
                if (!int.TryParse(Anno.Text, out int date) || String.IsNullOrEmpty(Anno.Text) || date < DateTime.Now.Year)
                {
                    MessageBox.Show("Inserire una data valida.");
                    return;
                }

                articoli[num] = new ArticoloAlimentare(articoli[num - 1].GetHashCode(), date, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
                return;
            }

            if (ArtAlimFreRadio.Checked)
            {
                if (!int.TryParse(Anno.Text, out int date) || String.IsNullOrEmpty(Anno.Text) || date < 2023)
                {
                    MessageBox.Show("Inserire una data valida.");
                    return;
                }


                if (!int.TryParse(PrefCons.Text, out int days) || String.IsNullOrEmpty(PrefCons.Text) || days < 0 || days > 5)
                {
                    MessageBox.Show("Inserire un numero di giorni valido compreso tra 1 e 5");
                    return;
                }

                articoli[num] = new ArticoloAlimentareFresco(articoli[num - 1].GetHashCode(), days, date, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
                return;
            }

            if (ArtNAlimRadio.Checked)
            {
                if (String.IsNullOrEmpty(Materiale.Text))
                {
                    MessageBox.Show("Inserire un materiale valido.");
                    return;
                }

                articoli[num] = new ArticoloNonAlimentare(articoli[num - 1].GetHashCode(), Materiale.Text, RicCheck.Checked, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
            }
        }

        private void ScontBut_Click(object sender, EventArgs e)
        {
            Display.Clear();

            double tot = 0;

            for (int i = 1; i < num; i++)
            {
                Display.Items.Add(articoli[i].ToString());
                double sc = articoli[i].Sconta();
                tot += sc;
            }

            Display.Items.Add($"\n\n {tot}");
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < num; i++)
            {
                articoli[i] = null;
            }

            num = 0;
        }

        private void ArtAlimRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ArtAlimRadio.Checked)
            {
                Anno.Enabled = true;
                CartaFedCheck.Enabled = true;
                Desc.Enabled = true;
                PrezzoUnit.Enabled = true;

                PrefCons.Enabled = false;
                Materiale.Enabled = false;
                RicCheck.Enabled = false;
            }

            if (ArtAlimFreRadio.Checked)
            {
                Anno.Enabled = true;
                PrefCons.Enabled = true;
                CartaFedCheck.Enabled = true;
                Desc.Enabled = true;
                PrezzoUnit.Enabled = true;

                Materiale.Enabled = false;
                RicCheck.Enabled = false;
            }

            if (ArtNAlimRadio.Checked)
            {
                Anno.Enabled = false;
                PrefCons.Enabled = false;
                Desc.Enabled = true;
                PrezzoUnit.Enabled = true;
                
                CartaFedCheck.Enabled = true;
                Materiale.Enabled = true;
                RicCheck.Enabled = true;
            }
        }

        private void ArtNAlimRadio_CheckedChanged(object sender, EventArgs e)
        {
            ArtAlimRadio_CheckedChanged(sender, e);
        }

        private void ArtAlimFreRadio_CheckedChanged(object sender, EventArgs e)
        {
            ArtAlimRadio_CheckedChanged(sender, e);
        }

        private void OrdBut_Click(object sender, EventArgs e)
        {

        }
    }
}
