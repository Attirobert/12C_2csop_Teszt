using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;

namespace KöHenger_UnitTest
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör(sugár);
            kör.SetKerület();
            double vártEredm = 31.4;

            // Act - Végrehajtás

            // Assert - Kiértékelés
        }

        [TestMethod]
        public void Terület_Teszt()
        {
        }
    }
}
