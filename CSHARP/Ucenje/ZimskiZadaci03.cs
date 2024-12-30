using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci03
    {
        public static void Run()
        {
            Console.Write(  "Unesi velićinu niza: ");
            int n=int.Parse(Console.ReadLine());
            int[] niz = new int[n];

            Console.WriteLine("Ajd sad vrijednosti:");
            for(int i = 0;i<n;i++)
            {
                Console.Write("Vrijednost {0}: ",i+1);
                niz[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for(int i=0;i<n;i++)
            {
                suma = suma + niz[i];
            }

            Console.WriteLine("Zbroj svih vrijednosti je {0}", suma);
        }
    }
}
