using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Az osztály feladata:
A megadott bináris számot átváltja tízes alapú számmá és vissza.
Metódusok:
 - Konstruktor
 - Szám input sztringként. Megjegyzés: Mivel lehet olyan decimális szám, amely csak nullából és egyesből áll, ezért kikötjük, hogy a bináris szám első karaktere pl. 0 legyen!
 - Átváltás
 - Eredmény lekérése sztringként
 */
namespace AtvaltOOP
{
    public class Atvalt
    {

        // Osztályváltozók
        string eredmeny = string.Empty; // Az eredményt ebbe képezzük
        int decSzam = 0;   // Az átalakítandó decimális szám változója

        public Atvalt() { }
        public Atvalt(string szam) 
        {
            // Ellenőrzöm az inputot
            if (isBinaris(szam)) binarisToDecimalis(szam);  // Ha bináris, átalakítom decimálissá, egyébként...
            else if (isDecimal(szam)) decimalToBinaris(szam);   // ... ha decimális, akkor átalakítom binárissá, egyébként ...
            else throw new FormatException("A megadott adat nem szám!");    // ... hibás az adat
        }

        private void decimalToBinaris(string szam)
        {
            // A eljárás a 2-es maradékos osztás elve
            while (decSzam > 0)
            {
                eredmeny = decSzam % 2 + eredmeny;
                decSzam /= 2;
            }
        }

        private bool isDecimal(string szam)
        {
            // A decimálist úgy vizsgáljuk, hogy konvertálható-e
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam));  // Egyúttal el is tároljuk az eredményt
            }
            catch (Exception)
            {

                eredm = false;
            }

            return eredm;
        }

        private void binarisToDecimalis(string szam)
        {
            // Az eljárás a helyi és alaki érték szorzata
            int j = 1;
            for (int i = szam.Length-1; i > 0; i--)
            {
                decSzam += Convert.ToInt32(szam[i]) * j;
                j *= 2;
            }
        }

        private bool isBinaris(string szam)
        {
            bool eredm = true;  // 
            if (szam[0] == '0')     // Mivel az elvárás szerint a bináris szám első karaktere 0!
                for (int i=1; i < szam.Length; i++)
                    if (szam[i] != '0' && szam[i] != '1')   // ha nem egyenlő 0-val ÉS nem egyenlő 1-gyel, akkor már nem lehet bináris ...
                    {
                        eredm = false;
                        break;                  // ... ezért befejeződik a ciklus
                    }

            return eredm;
        }
    }
}
