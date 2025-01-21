using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z2
    {
        public static void Izvedi()
        {
            int godine = E14Metode.UcitajBroj("Upisi godine",1,120);
            if (godine < 18)
            {
                Console.WriteLine("Malo");
            }
            else
            {
                Console.WriteLine("Puno");
            }
         
        }





        
    }
}
