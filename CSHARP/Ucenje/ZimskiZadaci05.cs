using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci05
    {
        public static void Run()
        {
            Console.WriteLine("Unesi broj elemenata fibe: ");
            int n=int.Parse(Console.ReadLine());

            if (n<=0)
            {
                Console.WriteLine("Ne seri");
                return;
            }

            Console.WriteLine("Fibijev niz do tvog elementa:");
            int prethodni = 0, trenutni = 1;
            for (int i = 0; i < n; i++) 
            {
                
                
                Console.WriteLine(prethodni);
                int sljedeci = prethodni + trenutni;
                prethodni = trenutni;
                trenutni = sljedeci;
            }
        }
    }
}
