using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci08
    {
        public static void Run()
        {
            Console.WriteLine("Ako bi C° u F° biraj 1");
            Console.WriteLine("Ako bi F°  u C° biraj 2");
            Console.WriteLine("ili sacekajte operatera");
            
            int biraj = int.Parse(Console.ReadLine());

            switch (biraj) 
            {
                case 1:
                    Console.WriteLine("C°?:");
                    float c1= float.Parse(Console.ReadLine());
                    float f1 = c1 * 9 / 5 + 32;
                    Console.WriteLine("{0} C° je {1} F°",c1,f1);
                    break;
                case 2:
                    Console.WriteLine("F°?:");
                    float f2 = float.Parse(Console.ReadLine());
                    float c2 = (f2 - 32) * 5 / 9;
                    Console.WriteLine("{0} F° je {1} C°",f2,c2);
                    break;
                default:
                    Console.WriteLine("evo sad će operater samo što nije");
                    break;


            }
        }
    }
}
