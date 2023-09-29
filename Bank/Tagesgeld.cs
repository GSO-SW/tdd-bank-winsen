using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tagesgeld
    {
        private Konto verrechnungskonto;
        private double guthaben;
        private double zinssatz;
        private int verrechnungsKontoNr;


        public Tagesgeld(Konto verrechnungskonto) 
        {
            this.verrechnungskonto = verrechnungskonto;
        }


        public double Guthaben
        {
            get { return guthaben; }
        }

        public double Zinssatz
        {
            get { return zinssatz; }
            set { zinssatz = value; }
        }




        public int VerrechnungsKontoNr
        {
            get
            {
                return verrechnungsKontoNr;
            }
        }

        public Konto Verrechnungskonto
        {
            get { return verrechnungskonto;}
        }

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }


        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }

        }
        }
}
