using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Eo5_uvijetnoGrananjeSwitch
    {
        public static void run()
        {
            int broj = 3;

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("VD");
                    break;
                case 5:
                    Console.WriteLine("Odl");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;
            }
        }
    }
}
