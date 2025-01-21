using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Vjezba01
    {
        public static void Izvedi()
        {
            Prva();
            Druga(5);
            Druga(3, "Word");
        }
        /// <summary>
        /// Ne prima, ne vraca
        /// </summary>
        private static void Prva()
        {
                        Console.WriteLine("Prva metoda");
        }
        /// <summary>
        /// Prima, ne vraca
        /// </summary>
        /// <param name="i"></param>
        private static void Druga(int i)
        {
            Console.WriteLine("Prosljeđeno {0} i množeno sa 10 je {1}",i,i*10);
        }

        protected static void Druga(int i, string s)
        {
            Console.WriteLine("Primio sam {0} i {1}", i, s);
        }

        public static string Treca()
        {
            return "Vrati string";
        }

    }
}
