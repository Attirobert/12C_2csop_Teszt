using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    [Serializable]
    public class SajatException : Exception
    {
        // A következő három konstruktor kötelező
        public SajatException() : base()
        {
        }

        public SajatException(string message) : base(message)
        {
        }

        public SajatException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
