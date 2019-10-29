using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        internal plec value;

        public enum plec { K, M };

        public int obliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }
        public void przedrostek()
        {
            if (value == plec.M)
            {
                Console.WriteLine("Dyrektorem jest Pan" + this.imie + " " + this.nazwisko);

            }
            else
            {
                Console.WriteLine("Dyrektorem jest Pani" + this.imie + " " + this.nazwisko);
            }



        }
        public void bmi()
        {
            
            double Bmi = (double)waga / (wzrost / 100 * wzrost / 100);
            Console.WriteLine("{0}", Bmi);

            if (Bmi <= 18.5)
            {
                Console.WriteLine("Masz niedowage");
                Console.WriteLine("{0}", Bmi);
            }

            else if (Bmi <= 24.99)
            {
                Console.WriteLine("Twoja waga jest prawidlowa");
                Console.WriteLine("{0}", Bmi);
            }




            else if (Bmi <= 29.99)
                Console.WriteLine("Masz nadwage");

            else
                Console.WriteLine("Masz otylosc");

        }
    }
}
