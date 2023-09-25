using Bank;

namespace BankTests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlen_KontoEinzahltest()
        {
            //ARRANGE
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);

            //ACT
            int einzahlen_guthaben = 50;
            k1.Einzahlen(einzahlen_guthaben);

            //ASSERT
            Assert.AreEqual(150,k1.Guthaben);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Auszahlen_AuszahlenSollNichtGroﬂerAlsGuthabenSein()
        {
            //ARRANGE
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);

            //ACT
            int auszahlen_guthaben = 150;
            k1.Auszahlen(auszahlen_guthaben);

        }


        [TestMethod]
        public void Kontonummer_TestAufEingaben()
        {
            //ARRANGE
            int guthaben = 1000;
            int KtoNr = 1;
            string BLZ = "10000";
            Konto k1 = new Konto(guthaben,KtoNr,BLZ);



            //ACT
            k1.BuchhaltungCheck(KtoNr,BLZ);

            //ASSERT
            Assert.AreEqual(1, k1.KtoNr);
            Assert.AreEqual("10000", k1.BLZ);



        }


    }
}