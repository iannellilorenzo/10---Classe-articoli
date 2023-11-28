using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _prefCons;

        public int PrefCons
        {
            get { return _prefCons; }
            set
            {
                if (value > 5 || value < 0)
                {
                    _prefCons = 3;
                }
                else
                {
                    _prefCons = value;
                }
            }
        }

        public ArticoloAlimentareFresco() : base()
        {
            PrefCons = 3;
        }

        public ArticoloAlimentareFresco(int prefCons, int anno, string descrizione, double prezzoUnit, bool cartaFed) : base(anno, descrizione, prezzoUnit, cartaFed)
        {
            PrefCons = prefCons;
        }

        public ArticoloAlimentareFresco(ArticoloAlimentareFresco vecchioArtAlimFre, ArticoloAlimentare vecchioArtAlim, Articolo vecchioArt) : base(vecchioArtAlim, vecchioArt)
        {
            PrefCons = vecchioArtAlimFre.PrefCons;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Consumarsi entro: {PrefCons}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentareFresco other = (ArticoloAlimentareFresco)obj;
            
            if (base.Equals(other) && PrefCons == other.PrefCons)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            int perc = 2;

            for (int i = 5; i > PrefCons; i--)
            {
                perc += 2;
            }

            // Se ho solo la carta
            if (CartaFed && perc == 2)
            {
                return PrezzoUnit - base.Sconta() * (perc / 100);
            }

            // Se ho sia la carta che la condizione dei giorni
            if (CartaFed && perc > 2)
            {
                return PrezzoUnit - base.Sconta() * (perc / 100);
            }

            // Se ho solo la condizione dei giorni
            if (perc > 2)
            {
                return PrezzoUnit - PrezzoUnit * (perc / 100);
            }

            // Se non ho nessuna delle due
            return PrezzoUnit;
        }
    }
}
