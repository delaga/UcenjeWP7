using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15_rekurzija
    {
        public static void Ajd()
        {
            Console.WriteLine("Ima li koga?");
            //Rekurzija();

            Console.WriteLine(Zbroji(100));
        }


        private static void Rekurzija() // nema prekida pa ne valja
        {
            Rekurzija();
        }

        public static int Zbroji(int broj)
        {

            if (broj == 1) //uvijet prekida
            {
                return 1;
            }

            return broj + Zbroji(broj - 1);
            
        }



    }
}
