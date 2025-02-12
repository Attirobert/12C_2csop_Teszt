using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Haromszogek;

namespace Haromszogek_UnitTest
{
    [TestClass]

    public class Haromszog_Class
    {
        Haromszog haromszog = new Haromszog();
        [TestMethod]
        public void isEgyenloOldalu_Test_True()
        {
            //arrange - teszt feltételek beállítása
            haromszog.setOldalak(16, 16, 16);

            bool vartEredmeny=true;
            bool kapottEredmeny;
            //act - teszt végrehajtása
            kapottEredmeny=haromszog.isEgyenloOldalu();

            //assert - teszt kiértékelése
            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }
        [TestMethod]
        public void isEgyenloOldalu_Test_False() 
        {
            
            haromszog.setOldalak(-16, 16, 16);
            bool vartEredmeny=false;
            bool kapottEredmeny;

            //act- teszt végrehajtása
            kapottEredmeny = haromszog.isEgyenloOldalu();

            //assert-teszt kiértékelése
            Assert.AreEqual(vartEredmeny, kapottEredmeny);
        }

        [TestMethod]
        public void isHaromszog_Test_True()
        {
            //Arrange - Teszt környezet beállítása
            haromszog.setOldalak(16, 24, 32);
            bool vartEredmeny=true;
            bool kapottEredmeny;

            //Act - Teszt végrehajtása
            kapottEredmeny = haromszog.isHaromszog();

            //Assert - Teszt kiértékelése
            Assert.AreEqual(vartEredmeny , kapottEredmeny);
        }
    }
}
