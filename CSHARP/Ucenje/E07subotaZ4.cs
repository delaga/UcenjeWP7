using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07subotaZ4
    {
        public static void Run()
        {
            Console.WriteLine("Unesi ime grada: ");
            string grad=Console.ReadLine();

            switch (grad) {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Blitvari");
                    break;
                case "Čakovec":
                    Console.WriteLine("Tamo gore");
                    break;
                case "Pula":
                    Console.WriteLine("More");
                    break;
                default:
                    Console.WriteLine("Nema");
                    break;

            }
        }
    }
}
