using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloAlimentare : Articolo
    {
        private int _anno;

        public int Anno
        {
            get { return _anno; }
            set
            {
                if (this is ArticoloAlimentare)
                    _anno = value;
                else
                    _anno = DateTime.Now.Year;
            }
        }

        public ArticoloAlimentare() : base()
        {
            Anno = DateTime.Now.Year + 2;
        }

        public ArticoloAlimentare(int anno, string descrizione, double prezzoUnit, bool cartaFed) : base(descrizione, prezzoUnit, cartaFed)
        {
            Anno = anno;
        }

        public ArticoloAlimentare(ArticoloAlimentare vecchioArtAlim, Articolo vecchioArt) : base(vecchioArt)
        {
            Anno = vecchioArtAlim.Anno;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Anno: {Anno}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentare other = (ArticoloAlimentare)obj;
            
            if (base.Equals(other) && Anno == other.Anno)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            // Se ho sia la carta che la condizione dell'anno
            if ((CartaFed && Anno == DateTime.Now.Year) && (CartaFed))
            {
                return PrezzoUnit - base.Sconta() * (20 / 100);
            }

            // Se ho solo la carta
            if (!(Anno == DateTime.Now.Year) && (CartaFed))
            {
                base.Sconta();
            }
            
            // Se ho solo la condizione dell'anno
            if (Anno == DateTime.Now.Year && CartaFed == false)
            {
                return PrezzoUnit - PrezzoUnit * (20 / 100);
            }

            // Se non ho nessuna delle due
            return PrezzoUnit;
        }
    }
}
