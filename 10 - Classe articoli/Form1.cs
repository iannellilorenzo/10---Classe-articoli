﻿using System;
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
        int num;
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
                return;
            }
        }
    }
}
