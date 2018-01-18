using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Serwis : Iserwis
    {
        private List<Elektronika> doNaprawy = new List<Elektronika>();
        private List<Komputer> komputery = new List<Komputer>();
        public Serwis()
        {
        }
        public void DodajTelewizor(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.Add(new Telewizor(marka,numerSeryjny,usterka));
        }
        public void DodajKomputer(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.Add(new Komputer(marka,numerSeryjny,usterka));
        }
        public override string ToString()
        {
            string opis = "";
            opis += "Sprzęt do naprawy:" + Environment.NewLine;
            foreach (var element in doNaprawy)
            {
                opis += element.ToString() + Environment.NewLine;
            }
            return opis;
        }
        public void Polacz()
        {
            doNaprawy.AddRange(komputery);
        }
        public void Podziel()
        {
            foreach (var element in komputery)
            {
                doNaprawy.Remove(element);
            };
        }
        public void Napraw()
        {
            doNaprawy.Remove(doNaprawy.First());
        }
        public void Napraw(int nr)
        {
            // doNaprawy.Remove(doNaprawy.Find(x => x.numerSeryjny.Contains(nr)));
        }
    }

}
