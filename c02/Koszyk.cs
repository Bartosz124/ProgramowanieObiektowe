using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02
{
    class Koszyk
    {
        List<Produkt> Produkty;
        public Koszyk()
        {
            this.Produkty = new List<Produkt>();
        }
        public void dodajProdukt(Produkt p)
        {
            this.Produkty.Add(p);
        }
        public void zawartoscKoszyka()
        {
            double suma = 0;
            int ilosc = 0;

            foreach (Produkt p in Produkty)
            {
                suma += p.cena;
                ilosc++;
                p.wypiszProdukt();

            }
            Console.WriteLine("Ilosc produktow {0} cenna {1} ", ilosc, suma);
        }
    }
}
