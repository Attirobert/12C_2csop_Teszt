using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    public class Haromszog
    {
        private int a = 0, b=0, c=0;
        public Haromszog() { }

        public void setOldalak(int a, int b, int c) {
        this.a= a; this.b = b; this.c= c;
        }
        public bool isEgyenloOldalu()
        {
            return (this.a == this.b && this.b == this.c && this.c == this.a);
        }
        public bool isEgyenloSzaru()
        {
            return (!isEgyenloOldalu() && (this.a == this.b || this.b == this.c || this.c == this.a));
        }
        public bool isHaromszog()
        {
            return (this.a + this.b > this.c && this.a + this.c > this.b && this.c + this.b > this.a);
        }

    }
}
