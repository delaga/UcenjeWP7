using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci06
    {
        public static void Run()
        {
            Console.WriteLine("Unesi neku riječ pa da ju obrnemo, hvala");
            string rijec = Console.ReadLine();

            string cejir = "";

            for (int i = rijec.Length - 1; i >= 0; i--)
            {
                cejir += rijec[i];
            }
            Console.WriteLine("Rijec {0} je obrnuto = {1}", rijec, cejir);
        }
    }
}