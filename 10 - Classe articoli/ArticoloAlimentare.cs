﻿using System;
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

        public override double Sconta()
        {
            // Se si considera lo sconto come: 20% statico del totale
            // return PrezzoUnit - PrezzoUnit * (20 / 100);

            // Se si considera lo sconto come: (5 + 20)% del totale
            // return PrezzoUnit - PrezzoUnit * (25 / 100);

            // Se si considera lo sconto come: 20% applicato al 5% del totale
            // return PrezzoUnit - base.Sconta() * (20 / 100);


            // Se ho sia la carta che la condizione dell'anno
            if ((CartaFed && Anno == DateTime.Now.Year) && (CartaFed))
            {
                return PrezzoUnit - base.Sconta() * (20 / 100);
            }

            // Se ho solo la carta
            if ((CartaFed && Anno == DateTime.Now.Year) == false && (CartaFed))
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
