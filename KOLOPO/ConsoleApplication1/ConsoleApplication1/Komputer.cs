using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Komputer:Elektronika
    {
        public Komputer(string marka, int numerSeryjny, string usterka)
            :base(marka,numerSeryjny,usterka)
        {

        }
        public override string ToString()
        {
            return "KOMPUTER Marka: " + marka + ", numer seryjny: " + numerSeryjny + "usterka: " + usterka;
        }
    }
}
