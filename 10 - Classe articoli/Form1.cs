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
        public int num;

        public Form1()
        {
            InitializeComponent();
            articoli = new Articolo[100];
            num = 0;
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

            double.TryParse(PrezzoUnit.Text, out double prezzo);

            if (ArtAlimRadio.Checked)
            { 
                int.TryParse(Anno.Text, out int date);
                articoli[num] = new ArticoloAlimentare(date, 0, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
                return;
            }

            if (ArtAlimFreRadio.Checked)
            {
                int.TryParse(Anno.Text, out int date);
                int.TryParse(PrefCons.Text, out int days);
                articoli[num] = new ArticoloAlimentareFresco(days, date, 0, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
                return;
            }

            if (ArtNAlimRadio.Checked)
            {
                articoli[num] = new ArticoloNonAlimentare(Materiale.Text, RicCheck.Checked, 0, Desc.Text, prezzo, CartaFedCheck.Checked);
                num++;
            }
        }

        private void ScontBut_Click(object sender, EventArgs e)
        {
            Display.Clear();

            double tot = 0;

            for (int i = 0; i < num; i++)
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
    }
}
