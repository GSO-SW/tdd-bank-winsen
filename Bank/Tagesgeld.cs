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


        public Tagesgeld(Konto verrechnungskonto)
        {
            this.verrechnungskonto = verrechnungskonto;
        }




        public int VerrechnungsKontoNr
        {
            get { return verrechnungskonto.KontoNr; }
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




        public Konto Verrechnungskonto
        {
            get { return verrechnungskonto;}
        }





        public void Einzahlen(double betrag)
        {
            verrechnungskonto.Auszahlen(betrag);
            guthaben += betrag;
        }


        public void Auszahlen(double betrag)
        {
            verrechnungskonto.Einzahlen(betrag);
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
