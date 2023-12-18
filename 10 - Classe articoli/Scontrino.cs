using System.Runtime.InteropServices;

namespace _10___Classe_articoli
{
    public class Scontrino
    {
        private Articolo[] articoli;
        private static int num;

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

            for (int i = 0; i < num; i++)
            {
                if (i == num - 1)
                    ret += $"[ {articoli[i]} ]\n";
                else
                    ret += $"[ {articoli[i]} ], \n";
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

        public void Azzera()
        {
            for (int i = 0; i < articoli.Length; i++)
            {
                articoli[i] = null;
            }

            num = 0;
        }

        public double Totale()
        {
            double tot = 0;

            for (int i = 0; i < num; i++)
            {
                tot += articoli[i].Sconta() * articoli[i].Quantita;
            }

            return tot;
        }

        public void Sort(int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = articoli[leftIndex].PrezzoUnit;

            while (i <= j)
            {
                while (articoli[i].PrezzoUnit < pivot)
                {
                    i++;
                }

                while (articoli[j].PrezzoUnit > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Articolo temp = articoli[i];
                    articoli[i] = articoli[j];
                    articoli[j] = temp;
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
                if (toFindOrInc.Equals(articoli[i]) && search)
                {
                    ret = i;
                    break;
                }

                if (toFindOrInc.Equals(articoli[i]) && !search)
                {
                    articoli[i].Quantita++;
                    return -2;
                }
            }

            return ret;
        }
    }
}
