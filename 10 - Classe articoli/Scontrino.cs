using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class Scontrino
    {
        private Articolo[] articoli;
        private static int num = 0;

        public Articolo[] Articoli
        {
            get { return articoli; }
            set { articoli = value; }
        }

        public Scontrino()
        {
            Articoli = new Articolo[100];
        }

        public Scontrino(int dim)
        {
            Articoli = new Articolo[dim];
        }

        public Scontrino(Articolo[] articoli)
        {
            Articoli = articoli;
        }

        public override string ToString()
        {
            string ret = "";

            for (int i = 0; i < Articoli.Length; i++)
            {
                if (i == Articoli.Length - 1)
                    ret += $"[ {Articoli[i]} ]";
                else
                    ret += $"[ {articoli[i]} ] , ";
            }

            return ret;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Scontrino other = (Scontrino)obj;

            if (this == other)
            {
                return true;
            }

            return false;
        }

        public void Aggiunta(Articolo toAdd)
        {
            articoli[num] = toAdd;
            num++;
        }
    }
}
