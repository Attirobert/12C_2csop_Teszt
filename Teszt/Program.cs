using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    public class Program
    {
        public static void Main()
        {
            SajatException sajatException = new SajatException("Ez a saját kivételkezelőm");
            Console.WriteLine("Helló Világ!");

            Console.WriteLine("Dobok egy hátast.");
            if (true) throw sajatException;

            Console.ReadKey();
        }
    }
}
