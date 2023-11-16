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

        public ArticoloNonAlimentare(string materiale, bool riciclabile, int codice, string descrizione, double prezzoUnit, bool cartaFed) : base(codice, descrizione, prezzoUnit, cartaFed)
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
            // Se si considera lo sconto come: 10% statico del totale
            // return PrezzoUnit - PrezzoUnit * (10 / 100);

            // Se si considera lo sconto come: (10 + 20)% del totale
            // return PrezzoUnit - PrezzoUnit * (30 / 100);

            // Se si considera lo sconto come: 10% applicato al 5% del totale
            // return PrezzoUnit - base.Sconta() * (10 / 100);


            // Se ho sia la carta che la condizione dell'anno
            if ((CartaFed && Riciclabile) && (CartaFed))
            {
                return PrezzoUnit - base.Sconta() * (10 / 100);
            }

            // Se ho solo la carta
            if ((CartaFed && Riciclabile) == false && (CartaFed))
            {
                base.Sconta();
            }
            
            // Se ho solo la condizione dell'anno
            if (Riciclabile && CartaFed == false)
            {
                return PrezzoUnit - PrezzoUnit * (10 / 100);
            }

            // Se non ho nessuna delle due
            return PrezzoUnit;
        }
    }
}
