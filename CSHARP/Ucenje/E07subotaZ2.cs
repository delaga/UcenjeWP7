using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07subotaZ2
    {
        public static void Izvedi()
        {
            Console.WriteLine("Koliko godina?");

            int godina = int.Parse(Console.ReadLine());

            if (godina <= 0 || godina >= 112) { Console.WriteLine("Greška"); }
            else
            {
                if (godina >= 18)
                {
                    Console.WriteLine("Punoljetan");
                }
                else { Console.WriteLine("Balonja"); }
            }

            Console.WriteLine("Korisnik {0} punoljetna osoba {1}", godina>=18 ? "je":"nije", godina);
        }
    }
}