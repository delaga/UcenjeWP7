using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07subotaZ5
    {
        public static void Run()
        {
            Console.WriteLine("Unesi broj 1-7:");
            int dan = int.Parse(Console.ReadLine());

            switch (dan)
            {
                case 6:
                case 7:
                    Console.WriteLine("Odmaraj");
                    break;
                case 1:
                case 3:
                    Console.WriteLine("Treniraj");
                    break;

                case 2:
                case 4:
                    Console.WriteLine("Uci");
                    break;
                case 5:
                    Console.WriteLine("kino");
                    break;
                default: { Console.WriteLine("Nije broj od 1-7"); break; }


            }
        }
    }
}