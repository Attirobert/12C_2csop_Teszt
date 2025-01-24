using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;
/*
 * Ne felejtsük el, hogy a tesztelt metódusokat public-ra kell állítani! A tesztek lefutása után visszaállíthatók
 */
namespace AtvaltOOP_UnitTeszt
{
    [TestClass]
    public class Atvalt_ClassUnitTest   // Az Teszt osztály nevében jelzem, hogy melyik osztályt tesztelem
    {
        // Mivel mindegyik teszt az osztály metódusait teszteli, ezért az osztály itt egyszer példányosítható
        Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void iSdecimal_True()  // A tesztmetódus nevében jelzem, hogy melyik metódust tesztelem és mire
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "21";
            bool vartEredm = true,
                kapottEredm = false;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void iSdecimal_False()  // Ha nem szám
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "2k1";
            bool vartEredm = false,
                kapottEredm = false;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void iSdecimal_False2()  // Ha szám, de bináris
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "0110";
            bool vartEredm = false,
                kapottEredm = false;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
