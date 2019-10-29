using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] tab = { 1, 2, 3 };

             for (int i = tab.Length -1; i >= 0; i)
             {
                 Console.Write("{0},", tab[i]);
             }
            */

            /*double a, b, c, max, pom1, pom2;
            Console.WriteLine("Podaj trzy liczby");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if ( a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine(" wszystkie boki muszą być różne od 0");
                Console.ReadKey();
                return;
            }
            if (a >=b && a>= c)

            {
                max = a;
                pom1 = b;
                pom2 = c;

            }
            else if (b >=a && b>=c)
            {
                max = b;
                pom1 = a;
                pom2 = c;
            }
            else
            {
                max = c;
                pom1 = a;
                pom2 = b;
            }
            if(max<pom1+pom2)
            {
                Console.WriteLine("Trojkat istnieje");

            }
            else
            {
                Console.WriteLine("Trojkat nie istnieje");
            }
            */
            /* int a;
              Console.WriteLine("Podaj liczbe");
              a = int.Parse(Console.ReadLine());

              while (a < 5 || a > 15) 
              {
                  Console.WriteLine("podales chujowa liczbe podaj jeszcze raz");
                  a = int.Parse(Console.ReadLine());
              }
              while (a > 0)
              {
                  a--;
                  Console.WriteLine("{0}", a);
              }
              */
            /* int a;
            Console.WriteLine("Podaj liczbe");
            a = int.Parse(Console.ReadLine());
            

            do
            {
                Console.WriteLine("Podaj liczbe");
                a = int.Parse(Console.ReadLine());
            }
            while (a > 4 && a < 7 && a != 10);

          Console.WriteLine("Podałeś prawidłową liczbe");
            Console.ReadKey();
            */
        }
    }
    }