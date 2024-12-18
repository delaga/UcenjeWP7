using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01_Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E01_Z1");
            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine();

            Console.Write("Unesi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("{0} {1}", prezime,ime);
        }
        

    }
}
