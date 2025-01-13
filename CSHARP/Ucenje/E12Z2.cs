using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z2
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi prvu rijec:");
            string prva = Console.ReadLine();


            Console.WriteLine("Unesi drugu rijec:");
            string druga = Console.ReadLine();

            string avrp = ""; string agurd = "";

            for (int i = prva.Length - 1; i >= 0; i--)
            {
                avrp += prva[i];
            }

            for (int i = druga.Length - 1; i >= 0; i--)
            {
                agurd += druga[i];
            }

            Console.Write(agurd + avrp);
        }
    }
}
