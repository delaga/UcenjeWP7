using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12ForEach
    {
        public static void Run()
        {
            Console.WriteLine("Unesi ime ");
            string grad=Console.ReadLine();

            for (int i = 0; i < grad.Length; i++) 
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("-----------------");

            foreach(char znak in grad)
            {

                Console.WriteLine(znak);
            }

            Console.WriteLine("-----------------");
            for (int i = grad.Length-1; i<=0;i--)
            {
                Console.WriteLine(grad[i]);
            }

            int[] brohjevi = { 1, 2, 65, 8, 4796, };




        }
    }
}
