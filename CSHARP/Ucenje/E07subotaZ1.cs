using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07subotaZ1
    {
        public static void izvedi()
        {
            Console.Write("Unesi 10-90: ");
            int broj = int.Parse(Console.ReadLine());


            Console.WriteLine(broj%10);

            Console.WriteLine("Ponovi unos: ");
            Console.WriteLine(Console.ReadLine()[1]);

            Console.WriteLine("______________");
            Console.WriteLine(broj / 10);


        }
    }
}
