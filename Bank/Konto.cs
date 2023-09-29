using System;

namespace Bank
{
    public class Konto
    {
        private double guthaben;
        private static int letztekontoNr = 0;   
        private int kontoNr ;

        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(double guthaben)

        {
            letztekontoNr++;
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }

            this.guthaben = guthaben;
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
                throw new("Guthaben nicht ausreichend");
            }
        }

        public int KontoNr 
        {
            get
            {
                return kontoNr;
            }
        }
    }
}