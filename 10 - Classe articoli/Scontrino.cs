using System.Runtime.InteropServices;

namespace _10___Classe_articoli
{
    public class Scontrino
    {
        private Articolo[] _articoli;
        private static int num;

        public Articolo[] Articoli
        {
            get { return _articoli; }
            set { _articoli = value; }
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

            for (int i = 0; i < num; i++)
            {
                if (i == num - 1)
                    ret += $"[ {Articoli[i]} ]\n";
                else
                    ret += $"[ {Articoli[i]} ], \n";
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
            Articoli[num] = toAdd;
            num++;
        }

        public void Azzera()
        {
            for (int i = 0; i < Articoli.Length; i++)
            {
                Articoli[i] = null;
            }

            num = 0;
        }

        public double Totale()
        {
            double tot = 0;

            for (int i = 0; i < num; i++)
            {
                tot += Articoli[i].Sconta() * Articoli[i].Quantita;
            }

            return tot;
        }

        public void Sort(int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = Articoli[leftIndex].PrezzoUnit;

            while (i <= j)
            {
                while (Articoli[i].PrezzoUnit < pivot)
                {
                    i++;
                }

                while (Articoli[j].PrezzoUnit > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Articolo temp = Articoli[i];
                    Articoli[i] = Articoli[j];
                    Articoli[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Sort(leftIndex, j);
            if (i < rightIndex)
                Sort(i, rightIndex);
        }

        public int Ricerca(Articolo toFindOrInc, bool search)
        {
            int ret = -1;

            for (int i = 0; i < num; i++)
            {
                if (toFindOrInc.Equals(Articoli[i]) && search)
                {
                    ret = i;
                    break;
                }

                if (toFindOrInc.Equals(Articoli[i]) && !search)
                {
                    Articoli[i].Quantita++;
                    return -2;
                }
            }

            return ret;
        }
    }
}
