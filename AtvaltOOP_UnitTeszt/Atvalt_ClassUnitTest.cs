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

        // Tesztelni az isBinaris metódust igaz és hamis adatokra is
        // A teszt metódusok nevei: isBinaris_True() és isBinaris_False

        [TestMethod]
        public void iSBinaris_False()  // Ha szám, de nem bináris
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "8";
            bool vartEredm = false,
                kapottEredm = false;


            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isBinaris(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void iSBinaris_False2()  // Ha szám 0 1 , de nem bináris
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "111";
            bool vartEredm = false,
                kapottEredm = false;


            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isBinaris(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void iSBinaris_True()  // Ha szám bináris
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "00111";
            bool vartEredm = true,
                kapottEredm = false;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isBinaris(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }
        // Tesztelni a decimalToBinaris metódust igaz és hamis adatokra is.
        // A teszt metódusok nevei: decimalToBinaris_True() és decimalToBinaris_False
        [TestMethod]

        public void decimalToBinaris_True()
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "111";
            string vartEredm = "01101111",
                kapottEred = String.Empty;

            // Act - A vizsgált metódus végrehajtása
            kapottEred = atvalt.decimalToBinaris(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEred, vartEredm);
        }

        public void decimalToBinaris_False()
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "1111";
            string vartEredm = "0101110",
                kapottEredm = String.Empty;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.decimalToBinaris(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        // Tesztelni a binarisToDecimalis metódust igaz és hamis adatokra is.
        // A teszt metódusok nevei: binarisToDecimalis_True() és binarisToDecimalis_False
        public void binarisToDecimalis_True()
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "0101011";
            int vartEredm = 43,
                kapottEredm = 0;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.binarisToDecimalis(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        public void binarisToDecimalis_False()
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "001010";
            int vartEredm = 52, // Mivel nem egyezést vizsgálunk, ezért ez is tetszőleges érték lehet
                kapottEredm = 0;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.binarisToDecimalis(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreNotEqual(kapottEredm, vartEredm);
        }

    }
}
