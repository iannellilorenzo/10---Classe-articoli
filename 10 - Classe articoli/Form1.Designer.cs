﻿namespace _10___Classe_articoli
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Desc = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.ArtNAlimRadio = new System.Windows.Forms.RadioButton();
            this.ArtAlimRadio = new System.Windows.Forms.RadioButton();
            this.ArtAlimFreRadio = new System.Windows.Forms.RadioButton();
            this.PrezzoLabel = new System.Windows.Forms.Label();
            this.PrezzoUnit = new System.Windows.Forms.TextBox();
            this.CartaFedCheck = new System.Windows.Forms.CheckBox();
            this.Display = new System.Windows.Forms.ListView();
            this.AnnoLabel = new System.Windows.Forms.Label();
            this.Anno = new System.Windows.Forms.TextBox();
            this.PrefConsLabel = new System.Windows.Forms.Label();
            this.PrefCons = new System.Windows.Forms.TextBox();
            this.RicCheck = new System.Windows.Forms.CheckBox();
            this.MaterialeLabel = new System.Windows.Forms.Label();
            this.Materiale = new System.Windows.Forms.TextBox();
            this.AggBut = new System.Windows.Forms.Button();
            this.ScontBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(12, 31);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(117, 20);
            this.Desc.TabIndex = 0;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(12, 15);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(100, 13);
            this.DescLabel.TabIndex = 1;
            this.DescLabel.Text = "Nome e descrizione";
            // 
            // ArtNAlimRadio
            // 
            this.ArtNAlimRadio.AutoSize = true;
            this.ArtNAlimRadio.Location = new System.Drawing.Point(29, 79);
            this.ArtNAlimRadio.Name = "ArtNAlimRadio";
            this.ArtNAlimRadio.Size = new System.Drawing.Size(135, 17);
            this.ArtNAlimRadio.TabIndex = 2;
            this.ArtNAlimRadio.TabStop = true;
            this.ArtNAlimRadio.Text = "Articolo Non Alimentare";
            this.ArtNAlimRadio.UseVisualStyleBackColor = true;
            // 
            // ArtAlimRadio
            // 
            this.ArtAlimRadio.AutoSize = true;
            this.ArtAlimRadio.Location = new System.Drawing.Point(29, 102);
            this.ArtAlimRadio.Name = "ArtAlimRadio";
            this.ArtAlimRadio.Size = new System.Drawing.Size(112, 17);
            this.ArtAlimRadio.TabIndex = 3;
            this.ArtAlimRadio.TabStop = true;
            this.ArtAlimRadio.Text = "Articolo Alimentare";
            this.ArtAlimRadio.UseVisualStyleBackColor = true;
            // 
            // ArtAlimFreRadio
            // 
            this.ArtAlimFreRadio.AutoSize = true;
            this.ArtAlimFreRadio.Location = new System.Drawing.Point(29, 125);
            this.ArtAlimFreRadio.Name = "ArtAlimFreRadio";
            this.ArtAlimFreRadio.Size = new System.Drawing.Size(147, 17);
            this.ArtAlimFreRadio.TabIndex = 4;
            this.ArtAlimFreRadio.TabStop = true;
            this.ArtAlimFreRadio.Text = "Articolo Alimentare Fresco";
            this.ArtAlimFreRadio.UseVisualStyleBackColor = true;
            // 
            // PrezzoLabel
            // 
            this.PrezzoLabel.AutoSize = true;
            this.PrezzoLabel.Location = new System.Drawing.Point(151, 15);
            this.PrezzoLabel.Name = "PrezzoLabel";
            this.PrezzoLabel.Size = new System.Drawing.Size(77, 13);
            this.PrezzoLabel.TabIndex = 6;
            this.PrezzoLabel.Text = "Prezzo all\'unità";
            // 
            // PrezzoUnit
            // 
            this.PrezzoUnit.Location = new System.Drawing.Point(151, 31);
            this.PrezzoUnit.Name = "PrezzoUnit";
            this.PrezzoUnit.Size = new System.Drawing.Size(117, 20);
            this.PrezzoUnit.TabIndex = 5;
            // 
            // CartaFedCheck
            // 
            this.CartaFedCheck.AutoSize = true;
            this.CartaFedCheck.Location = new System.Drawing.Point(29, 226);
            this.CartaFedCheck.Name = "CartaFedCheck";
            this.CartaFedCheck.Size = new System.Drawing.Size(89, 17);
            this.CartaFedCheck.TabIndex = 7;
            this.CartaFedCheck.Text = "Carta Fedeltà";
            this.CartaFedCheck.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(822, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(400, 430);
            this.Display.TabIndex = 8;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.List;
            // 
            // AnnoLabel
            // 
            this.AnnoLabel.AutoSize = true;
            this.AnnoLabel.Location = new System.Drawing.Point(323, 15);
            this.AnnoLabel.Name = "AnnoLabel";
            this.AnnoLabel.Size = new System.Drawing.Size(92, 13);
            this.AnnoLabel.TabIndex = 10;
            this.AnnoLabel.Text = "Anno di scadenza";
            // 
            // Anno
            // 
            this.Anno.Location = new System.Drawing.Point(323, 31);
            this.Anno.Name = "Anno";
            this.Anno.Size = new System.Drawing.Size(117, 20);
            this.Anno.TabIndex = 9;
            // 
            // PrefConsLabel
            // 
            this.PrefConsLabel.AutoSize = true;
            this.PrefConsLabel.Location = new System.Drawing.Point(490, 15);
            this.PrefConsLabel.Name = "PrefConsLabel";
            this.PrefConsLabel.Size = new System.Drawing.Size(107, 13);
            this.PrefConsLabel.TabIndex = 12;
            this.PrefConsLabel.Text = "Da consumarsi entro:";
            // 
            // PrefCons
            // 
            this.PrefCons.Location = new System.Drawing.Point(490, 31);
            this.PrefCons.Name = "PrefCons";
            this.PrefCons.Size = new System.Drawing.Size(117, 20);
            this.PrefCons.TabIndex = 11;
            // 
            // RicCheck
            // 
            this.RicCheck.AutoSize = true;
            this.RicCheck.Location = new System.Drawing.Point(29, 178);
            this.RicCheck.Name = "RicCheck";
            this.RicCheck.Size = new System.Drawing.Size(71, 17);
            this.RicCheck.TabIndex = 17;
            this.RicCheck.Text = "Riciclicità";
            this.RicCheck.UseVisualStyleBackColor = true;
            // 
            // MaterialeLabel
            // 
            this.MaterialeLabel.AutoSize = true;
            this.MaterialeLabel.Location = new System.Drawing.Point(678, 15);
            this.MaterialeLabel.Name = "MaterialeLabel";
            this.MaterialeLabel.Size = new System.Drawing.Size(50, 13);
            this.MaterialeLabel.TabIndex = 19;
            this.MaterialeLabel.Text = "Materiale";
            // 
            // Materiale
            // 
            this.Materiale.Location = new System.Drawing.Point(678, 31);
            this.Materiale.Name = "Materiale";
            this.Materiale.Size = new System.Drawing.Size(117, 20);
            this.Materiale.TabIndex = 18;
            // 
            // AggBut
            // 
            this.AggBut.Location = new System.Drawing.Point(216, 79);
            this.AggBut.Name = "AggBut";
            this.AggBut.Size = new System.Drawing.Size(166, 64);
            this.AggBut.TabIndex = 20;
            this.AggBut.Text = "Aggiunta";
            this.AggBut.UseVisualStyleBackColor = true;
            this.AggBut.Click += new System.EventHandler(this.AggBut_Click);
            // 
            // ScontBut
            // 
            this.ScontBut.Location = new System.Drawing.Point(417, 79);
            this.ScontBut.Name = "ScontBut";
            this.ScontBut.Size = new System.Drawing.Size(166, 64);
            this.ScontBut.TabIndex = 21;
            this.ScontBut.Text = "Scontrino";
            this.ScontBut.UseVisualStyleBackColor = true;
            this.ScontBut.Click += new System.EventHandler(this.ScontBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 457);
            this.Controls.Add(this.ScontBut);
            this.Controls.Add(this.AggBut);
            this.Controls.Add(this.MaterialeLabel);
            this.Controls.Add(this.Materiale);
            this.Controls.Add(this.RicCheck);
            this.Controls.Add(this.PrefConsLabel);
            this.Controls.Add(this.PrefCons);
            this.Controls.Add(this.AnnoLabel);
            this.Controls.Add(this.Anno);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.CartaFedCheck);
            this.Controls.Add(this.PrezzoLabel);
            this.Controls.Add(this.PrezzoUnit);
            this.Controls.Add(this.ArtAlimFreRadio);
            this.Controls.Add(this.ArtAlimRadio);
            this.Controls.Add(this.ArtNAlimRadio);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.Desc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.RadioButton ArtNAlimRadio;
        private System.Windows.Forms.RadioButton ArtAlimRadio;
        private System.Windows.Forms.RadioButton ArtAlimFreRadio;
        private System.Windows.Forms.Label PrezzoLabel;
        private System.Windows.Forms.TextBox PrezzoUnit;
        private System.Windows.Forms.CheckBox CartaFedCheck;
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.Label AnnoLabel;
        private System.Windows.Forms.TextBox Anno;
        private System.Windows.Forms.Label PrefConsLabel;
        private System.Windows.Forms.TextBox PrefCons;
        private System.Windows.Forms.CheckBox RicCheck;
        private System.Windows.Forms.Label MaterialeLabel;
        private System.Windows.Forms.TextBox Materiale;
        private System.Windows.Forms.Button AggBut;
        private System.Windows.Forms.Button ScontBut;
    }
}

