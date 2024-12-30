using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci02
    {
        public static void Run()
        {
            Console.WriteLine("DDR daj broj: ");
            float broj = float.Parse(Console.ReadLine());

            if (broj > 0)
            {
                Console.WriteLine("Broj {0} je pozitivan", broj);
            }
            else if (broj < 0)
            {
                Console.WriteLine("Broj {0} je negativan", broj);
            }
            else
            {
                Console.WriteLine(" Broj {0} je evidentno i uočljivo nula!",broj);
            }

        }
    }
}
