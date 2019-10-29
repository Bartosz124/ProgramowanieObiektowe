using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02
{
    class Produkt
    {
        public string nazwa;
        public double cena;

        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public void wypiszProdukt()
        {
            Console.WriteLine("{0} , {1}", this.nazwa, this.cena);
        }
    }
}
