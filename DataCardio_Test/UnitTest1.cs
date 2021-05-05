using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataCardio_Test;
using CardioLibrary;

namespace DataCardio_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BattitoMax()
        {
            double x = 16;
            double y = DataCardio.Max(x);
            Assert.AreEqual(183.6, y);
            

        }

        [TestMethod]
        public void  BattitoMin()
        {
            double x = 16;
            double y = DataCardio.Min(x);
            Assert.AreEqual(142.8, y);

        }

        [TestMethod]
        public void FrequenzaCardiaca()
        {
            int x = 120;
            string y = DataCardio.Battiti(x);
            Assert.AreEqual("Tachicardico".ToLower(), y);

        }

        [TestMethod]
        public void Calorie()
        {
            int età = 16;
            double tempo = 45;
            string sesso = "femmina";
            int frequenza = 120;
            double peso = 80.5;

            double x = DataCardio.Calorie(età, tempo, sesso, frequenza, peso);
            Assert.AreEqual(261.383, x);

        }

        [TestMethod]
        public void Velocità()
        {
            double percorso = 5;
            double peso = 80.5;
            string v = "Corsa".ToLower();
            double x = DataCardio.Corsa_Camminata(percorso, peso, v);
            Assert.AreEqual(362.2, x);
        }
    }
}
