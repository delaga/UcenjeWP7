using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10WhilePetlja
    {
        public static void Run() 
        {
            //Console.WriteLine("Burek");

            //while radi sa bool

            while (true)
            {
                Console.WriteLine("Nest");
                break;
            }
            int i = 0;

            while (i++ < 10) 
            {
                Console.WriteLine("i");
            }

            Console.WriteLine("-----------------------");

            int j = 0;

            while (i >= 10 && j++ < 10) {
                Console.WriteLine(i*j);
            }

            int odBroja = 0;
            int doBroja = 10;

            for(int x=odBroja;x<=doBroja; x++)
            {
                Console.WriteLine(x);   
            }

            while (false)
            {
                Console.WriteLine("Neema"   );

            }





        }
    }
}
