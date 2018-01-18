using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Elektronika
    {
        protected string marka;
        protected int numerSeryjny;
        protected string usterka;

        public Elektronika(string marka,int numerSeryjny, string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = numerSeryjny;
            this.usterka = usterka;
        }
        public override string ToString()
        {
            return "Marka: " + marka + ", numer seryjny: "+numerSeryjny + "usterka: " + usterka;
        }
    }
}
