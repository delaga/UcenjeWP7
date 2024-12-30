using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci01
    {
        public static void Run()
        {
            Console.WriteLine("Unesi duljinu: ");
            float d = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesi širinu: ");
            float s = float.Parse(Console.ReadLine());

            float p = d * s;

            Console.WriteLine("Površina pravokutnike jr {0}", p);
        }
    }
}
