using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Car car1 = new Car();
             car1.marka = "BMW";
             car1.rok = 2004;

             Console.WriteLine("{0} {1}",car1.marka,  car1.rok);

             car1.srednieSpalanie = 11;
             Console.WriteLine("Koszt przejazdu {0} na trasie 100km wynosi {1}",car1.marka, car1.obliczkosztPrzejazdu(100,4.20));


             Car car2 = new Car();
             car2.marka = "Audi";

             car2.srednieSpalanie = 7;
             Console.WriteLine("Koszt przejazdu {0} na trasie 100km {1}", car2.marka,car2.obliczkosztPrzejazdu(100,3.50));
             */

            /* Osoba dyrektor = new Osoba();

            dyrektor.imie = "Mateusz";
            dyrektor.nazwisko = "Białek";
            dyrektor.rokUrodzenia = 1998;
            dyrektor.waga = 60;
            dyrektor.wzrost = 175;
            dyrektor.okulary = false;
            dyrektor.value = Osoba.plec.M;

            Console.WriteLine("{0} {1} {2} ", dyrektor.imie, dyrektor.nazwisko, dyrektor.obliczWiek());

            dyrektor.przedrostek();

    */
            /*Osoba pacjent = new Osoba();

            pacjent.imie = "Pawel";
            pacjent.nazwisko = "Antonczyk";
            pacjent.wzrost = 176;
            pacjent.waga = 74;

            pacjent.bmi();
            */

            Produkt gruszka = new Produkt("Gruszka", 15);
            Produkt chipsy = new Produkt("Chipsy", 7);

            Koszyk nr1 = new Koszyk();
            nr1.dodajProdukt(gruszka);
            nr1.dodajProdukt(chipsy);

            nr1.zawartoscKoszyka();


            

                Console.ReadKey();
        }
    }
}
