using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z1
    {
        
        /// <summary>
        /// Ucita 2 izbaci 1
        /// </summary>
        public static void Izvedi()
        {
            Console.WriteLine(E14Metode.UcitajBroj("Unesi 1 broj",0,int.MaxValue) + E14Metode.UcitajBroj("Unesi 2 broj",0,int.MaxValue));


        }
    }
}
