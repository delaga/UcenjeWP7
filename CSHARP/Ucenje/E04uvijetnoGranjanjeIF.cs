using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04uvijetnoGranjanjeIF
    {
        public static void Run()
        {
            //Console.WriteLine("Provjeri jel' 4");

            int broj = 8;

            bool uvijet = broj == 8;

            if (uvijet)
            {
                Console.WriteLine("Broj ima vrijednost 7");
            }

            if (broj == 7)
            {
                Console.WriteLine("Broj ima vrijednost 7");
            }

            if (uvijet)
            {

                Console.WriteLine("Ide inace ---");

            }
            else
            {
                Console.WriteLine("Nije 7");
            }

            if (broj == 6)
            {
                Console.WriteLine("sad je 6");
            }
            else if (broj == 7)
            {
                Console.WriteLine("sad je 7");
            }
            else
            {
                Console.WriteLine("Nije ni 6 ni 7");
            }

            broj = 1;
            int temp = 2;

            if (broj != 1 & temp < 0)
            {
                Console.WriteLine("Dnohla!!");
            }

            if (broj != 1 && temp < 0)
            {
                Console.WriteLine("Dnohla jako!!");
            }

            if (broj > 0 | temp > 0)
            { Console.WriteLine("Toplo"); }

            if (broj > 0 || temp > 0)
            { Console.WriteLine("Toplo oma"); }

            if (broj > 0)
            {
                int t = 8;
                Console.WriteLine(t);
            }

            





        }

    }
}