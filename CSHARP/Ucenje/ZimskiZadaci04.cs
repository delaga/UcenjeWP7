using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci04
    {
        public static void Run() 
        {
            Console.Write("Unesite broj ocjena: ");
            int brojOcjena = int.Parse(Console.ReadLine());

            int[] ocjene = new int[brojOcjena];

            Console.WriteLine("Unesite ocjene:");
            for (int i = 0; i < brojOcjena; i++)
            {
                Console.Write("Ocjena {0}: ",i+1);
                ocjene[i] = int.Parse(Console.ReadLine());
            }

            
            int zbroj = 0;
            for (int i = 0; i < brojOcjena; i++)
            {
                zbroj = zbroj + ocjene[i];
            }

            float prosjek = zbroj / brojOcjena;
            Console.WriteLine("Prosječna ocjena je: {0}",zbroj);
        }
    }
}
