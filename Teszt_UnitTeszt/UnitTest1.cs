using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teszt_UnitTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            string vartEredm = "Helló Világ!";

            // Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Teszt.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                // Assert: Kiértékelés
                Assert.AreEqual(vartEredm, kapottEredm);
            }
        }
    }
}
