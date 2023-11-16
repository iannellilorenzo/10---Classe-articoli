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

        public ArticoloAlimentare(int anno, int codice, string descrizione, double prezzoUnit, bool cartaFed) : base(codice, descrizione, prezzoUnit, cartaFed)
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
    }
}
