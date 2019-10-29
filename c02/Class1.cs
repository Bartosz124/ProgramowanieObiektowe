using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c02
{
   public class Car
    {
       public string marka;
       public int rok;
       private string model;
        private int iloscdrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        private double obliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (dlugoscTrasy * srednieSpalanie);
            return spalanie;
        }
        public double  obliczkosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztprzejazdu=(obliczSpalanie(dlugoscTrasy)* cenaPaliwa);

            return kosztprzejazdu;
        }
        public static void opiszTyp(string marka, double srednieSpalanie)
        {
            Console.WriteLine("[0} , {1}",marka, srednieSpalanie);
        }

       

        
    }
}
