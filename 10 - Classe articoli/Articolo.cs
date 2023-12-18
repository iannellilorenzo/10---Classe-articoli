using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class Articolo
    {
        private int _codice;
        private string _descrizione;
        private double _prezzoUnit;
        private bool _cartaFed;
        private int _quantita;

        public int Codice
        {
            get { return _codice; }
            set { _codice = GetHashCode(); }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public double PrezzoUnit
        {
            get { return _prezzoUnit; }
            set
            {
                if (value > 0)
                    _prezzoUnit = value;
                else
                    _prezzoUnit = 100; // throw new ArgumentOutOfRangeException("value", "Sono accettati valori interi maggiori di 0.");
            }
        }

        public bool CartaFed
        {
            get { return _cartaFed; }
            set { _cartaFed = value; }
        }

        public int Quantita
        {
            get { return _quantita; }
            set { _quantita = value; }
        }

        public Articolo()
        {
            Codice += 1;
            Descrizione = "";
            PrezzoUnit = 0;
            CartaFed = false;
            Quantita = 0;
        }

        public Articolo(int codice, string descrizione, double prezzoUnit, bool cartaFed, int quantita)
        {
            Codice = codice;
            Descrizione = descrizione;
            PrezzoUnit = prezzoUnit;
            CartaFed = cartaFed;
            Quantita = quantita;
        }

        public Articolo(Articolo vecchioArt)
        {
            Codice = vecchioArt.Codice;
            Descrizione = vecchioArt.Descrizione;
            PrezzoUnit = vecchioArt.PrezzoUnit;
            CartaFed = vecchioArt.CartaFed;
            Quantita = vecchioArt.Quantita;
        }

        public override string ToString()
        {
            string str = CartaFed ? "Abbonato" : "Non abbonato";
            return $"Codice: {Codice}; Descrizione: {Descrizione}; Prezzo Unitario: {PrezzoUnit}; Carta Fedeltà: {str}; Quantità: {Quantita}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() / 86438;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Articolo other = (Articolo)obj;
            
            if (Descrizione == other.Descrizione && PrezzoUnit == other.PrezzoUnit && CartaFed == other.CartaFed && Quantita == other.Quantita)
            {
                return true;
            }

            return false;
        }

        public int Compare(Articolo other)
        {
            int ret = 2;
            if (other != null)
            {
                if (PrezzoUnit == other.PrezzoUnit)
                    ret = -1;
                else if (PrezzoUnit > other.PrezzoUnit)
                    ret = 0;
                else if (PrezzoUnit < other.PrezzoUnit)
                    ret = 1;
            }
            return ret;
        }

        public virtual double Sconta()
        {
            if (CartaFed)
            {
                return PrezzoUnit - PrezzoUnit * 5 / 100;
            }

            return PrezzoUnit;
        }
    }
}
