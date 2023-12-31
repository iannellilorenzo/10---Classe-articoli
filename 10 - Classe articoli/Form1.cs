﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10___Classe_articoli
{
    public partial class Form1 : Form
    {
        public Articolo temp;
        public Scontrino tutto;
        public int num;
        public string[] intest;

        public Form1()
        {
            InitializeComponent();
            temp = new Articolo();
            tutto = new Scontrino();
            num = 0;
            intest = new string[] { "Codice", "Descrizione", "Prezzo unitario", "Carta fedeltà", "Quantità", "Anno di scadenza", "Consumare entro", "Materiale", "Riciclabilità" };
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

                temp = new ArticoloAlimentare(0, date, Desc.Text, prezzo, CartaFedCheck.Checked, 1);

                if (tutto.Ricerca(temp, false) == -2)
                {
                    MessageBox.Show("Articolo già presente, è stata incrementata la sua quantità.");
                    return;
                }

                tutto.Aggiunta(temp);
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

                temp = new ArticoloAlimentareFresco(0, days, date, Desc.Text, prezzo, CartaFedCheck.Checked, 1);

                if (tutto.Ricerca(temp, false) == -2)
                {
                    MessageBox.Show("Articolo già presente, è stata incrementata la sua quantità.");
                    return;
                }

                tutto.Aggiunta(temp);
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

                temp = new ArticoloNonAlimentare(0, Materiale.Text, RicCheck.Checked, Desc.Text, prezzo, CartaFedCheck.Checked, 1);

                if (tutto.Ricerca(temp, false) == -2)
                {
                    MessageBox.Show("Articolo già presente, è stata incrementata la sua quantità.");
                    Stampa();
                    return;
                }

                tutto.Aggiunta(temp);
                num++;
            }
        }

        private void ScontBut_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Stampa();
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            Display.Clear();
            tutto.Azzera();
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
            Display.Clear();
            tutto.Sort(0, num);
            Stampa();
        }

        public void Stampa()
        {
            Display.Clear();

            for (int i = 0; i < intest.Length; i++)
            {
                Display.Columns.Add($"{intest[i]}", 120);
            }

            // { "Codice", "Descrizione", "Prezzo unitario", "Carta fedeltà", "Quantità", "Anno di scadenza", "Consumare entro", "Materiale", "Riciclabilità" }

            for (int i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = tutto.Articoli[i].Codice.ToString();
                string str = tutto.Articoli[i].CartaFed ? "Abbonato" : "Non abbonato";

                if (tutto.Articoli[i] is ArticoloNonAlimentare)
                {
                    string strr = ((ArticoloNonAlimentare)tutto.Articoli[i]).Riciclabile ? "Riciclabile" : "Non riciclabile";

                    item.SubItems.Add(tutto.Articoli[i].Descrizione);
                    item.SubItems.Add(tutto.Articoli[i].PrezzoUnit.ToString());
                    item.SubItems.Add(str);
                    item.SubItems.Add(tutto.Articoli[i].Quantita.ToString());
                    item.SubItems.Add("---");
                    item.SubItems.Add("---");
                    item.SubItems.Add(((ArticoloNonAlimentare)tutto.Articoli[i]).Materiale);
                    item.SubItems.Add(strr);
                }

                if (tutto.Articoli[i] is ArticoloAlimentare)
                {
                    item.SubItems.Add(tutto.Articoli[i].Descrizione);
                    item.SubItems.Add(tutto.Articoli[i].PrezzoUnit.ToString());
                    item.SubItems.Add(str);
                    item.SubItems.Add(tutto.Articoli[i].Quantita.ToString());
                    item.SubItems.Add(((ArticoloAlimentare)tutto.Articoli[i]).Anno.ToString());
                    item.SubItems.Add("---");
                    item.SubItems.Add("---");
                    item.SubItems.Add("---");
                }

                if (tutto.Articoli[i] is ArticoloAlimentareFresco)
                {
                    item.SubItems.Add(tutto.Articoli[i].Descrizione);
                    item.SubItems.Add(tutto.Articoli[i].PrezzoUnit.ToString());
                    item.SubItems.Add(str);
                    item.SubItems.Add(tutto.Articoli[i].Quantita.ToString());
                    item.SubItems.Add(((ArticoloAlimentareFresco)tutto.Articoli[i]).Anno.ToString());
                    item.SubItems.Add(((ArticoloAlimentareFresco)tutto.Articoli[i]).PrefCons.ToString());
                    item.SubItems.Add("---");
                    item.SubItems.Add("---");
                }

                Display.Items.Add(item);
            }

            MessageBox.Show($"Il prezzo totale è: €{tutto.Totale()}");
        }

        
    }
}
