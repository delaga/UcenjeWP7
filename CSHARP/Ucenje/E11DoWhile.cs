using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11DoWhile
    {
        public static void Run()
        {

            do 
            {
                Console.WriteLine("Izvedi 1nom");
            } while (false);

            int broj = 0;
            do
            {
                if (broj % 2 == 0)
                {
                    Console.WriteLine(broj);
                }
                broj++;
            }
            while (broj<=28);


        }
    }
}
