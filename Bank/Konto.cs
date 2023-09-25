using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        private int ktoNr;

        public int KtoNr
        {
            get { return ktoNr; }
        }

        private string blz;

        public string BLZ
        {
            get { return blz; }
        }

        public Konto(int guthaben)
        {
            this.guthaben = guthaben;
            
        }

        public Konto(int guthaben,int ktoNr,string blz)
        {
            this.guthaben = guthaben;
            this.ktoNr = ktoNr;
            this.blz = blz;
        }

        public void BuchhaltungCheck(int KtoNR, string blz)
        {
            
        }

        public void Einzahlen(int betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(int betrag)
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
