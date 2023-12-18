using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public bool Riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value; }
        }

        public ArticoloNonAlimentare() : base()
        {
            Materiale = "";
            Riciclabile = false;
        }

        public ArticoloNonAlimentare(int codice, string materiale, bool riciclabile, string descrizione, double prezzoUnit, bool cartaFed, int quant) : base(codice, descrizione, prezzoUnit, cartaFed, quant)
        {
            Materiale = materiale;
            Riciclabile = riciclabile;
        }

        public ArticoloNonAlimentare(ArticoloNonAlimentare vecchioArtNonAlim, Articolo vecchioArt) : base(vecchioArt)
        {
            Materiale = vecchioArtNonAlim.Materiale;
            Riciclabile = vecchioArtNonAlim.Riciclabile;
        }

        public override string ToString()
        {
            string str = Riciclabile ? "Riciclabile" : "Non riciclabile";
            return $"{base.ToString()}; Materiale: {Materiale}; Riciclabilità: {str}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloNonAlimentare other = (ArticoloNonAlimentare)obj;
            
            if (base.Equals(other) && Materiale == other.Materiale && Riciclabile == other.Riciclabile)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            double franco = base.Sconta();

            // Sconta ulteriormente in base a franco
            if (Riciclabile)
            {
                return PrezzoUnit - franco * 10F / 100F;
            }

            // Se ho solo la carta o nessuna delle due
            return franco;
        }
    }
}
