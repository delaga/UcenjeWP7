using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci09
    {
        public static void Run()
        {
            Console.WriteLine("Koliko?");
            int brojElemenata = int.Parse(Console.ReadLine());

            int[] niz = new int[brojElemenata];

            for (int i = 0; i < brojElemenata; i++)
            {
                Console.WriteLine("Unesi {0}. broj", i + 1);
                niz[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(niz);
            Console.WriteLine("Sortirani:");
            for (int i = 0; i < niz.Length; i++)
            { 
                Console.Write(niz[i]+"-");
            }
        }
    }
}
