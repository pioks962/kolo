using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static Serwis pecet = new Serwis();
        private static char klawisz;

        public static void Legenda()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("A - dodaj tv");
            Console.WriteLine("B - dodaj komputer");
            Console.WriteLine("C - polacz");
            Console.WriteLine("T - podziel");
            Console.WriteLine("D - napraw");
            Console.WriteLine("E - napraw po nr seryjnym");
            Console.WriteLine("X - Wyjście");
        }

        public static void WczytajKlawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }

        public static void Dzialanie()
        {
            if (klawisz == 'A' || klawisz == 'a')
            {
                string marka = "";
                int numerSeryjny ;
                string usterka = "";
                Console.WriteLine("Podaj markę.");
                marka = Console.ReadLine();
                Console.WriteLine("Podaj numer seryjny.");
                numerSeryjny = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj usterkę.");
                usterka = Console.ReadLine();
                pecet.DodajKomputer(marka,numerSeryjny,usterka);

            }
            else if (klawisz == 'B' || klawisz == 'b')
            {
                string marka = "";
                int numerSeryjny;
                string usterka = "";
                Console.WriteLine("Podaj markę.");
                marka = Console.ReadLine();
                Console.WriteLine("Podaj numer seryjny.");
                numerSeryjny = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj usterkę.");
                usterka = Console.ReadLine();
                pecet.DodajTelewizor(marka, numerSeryjny, usterka);

            }
            else if (klawisz == 'C' || klawisz == 'c')
            {
                pecet.Polacz();
            }
            else if (klawisz == 'T' || klawisz == 't')
            {
                pecet.Podziel();
            }
            else if (klawisz == 'D' || klawisz == 'd')
            {
                pecet.Napraw();
            }
            else if (klawisz == 'E' || klawisz == 'e')
            {
                int numerSeryjny;
                Console.WriteLine("Podaj numer seryjny.");
                numerSeryjny = Int32.Parse(Console.ReadLine());
                pecet.Napraw(numerSeryjny);
            }
            else if (klawisz == 'X' || klawisz == 'x')
            {
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Legenda();
                WczytajKlawisz();
                Dzialanie();

            }

        }
    }
}
