using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07subotaZ3
    {
        public static void Run()
        {
            Console.WriteLine("Unesi prvi broj");
            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj");
            int broj2 = int.Parse(Console.ReadLine());

            if (broj1 > broj2)
            {
                Console.WriteLine("Broj {0}",broj1);
            }
            else if(broj1 == broj2)
                    {
                Console.WriteLine("Jednaki su");
                }
            else { 
                Console.WriteLine("Veći je {0}",broj2); 
            }
        }
    }
}
