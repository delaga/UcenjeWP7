using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01_UlazIzlaz
    {

        public static void Izvedi()
        {
            Console.WriteLine("Pozdrav svijetu!");

            Console.Write("Ovo je u liniji ");
            Console.WriteLine("ovo je u istoj liniji ali nakon ispisa ode u novu leniju");

            Console.WriteLine("1. red\n2. red\t nakon taba");

            Console.WriteLine(1);
            Console.WriteLine(true);
            Console.WriteLine(4.6);

            //Ulaz
            int i;
            Console.Write("Unesi cijeli broj: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Unio si {0}",i);


            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            Console.WriteLine("Unio si " + grad);

        }




    }
}
