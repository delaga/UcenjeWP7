using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z1
    {
        public static void Izvedi()
        {
            int brojac = 0;

            for (int i = 0; i < 100; i++)
            {
                brojac += i;
            }
            Console.WriteLine(brojac);

            brojac = 0;
            int b = 0;

            Console.WriteLine("------------");

            int[] brojevi = Enumerable.Range(1, 100).ToArray();

            int zbroj = 0;

            // Koristimo foreach petlju za zbrajanje
            foreach (int broj in brojevi)
            {
                zbroj += broj;
            }

            Console.WriteLine("Zbroj prvih 100 brojeva je: " + zbroj);

        }
    }
}
