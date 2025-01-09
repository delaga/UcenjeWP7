using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci07
    {
        public static void Run()
        {
            Console.Write("Unesite text:");
            string text = Console.ReadLine();

            string textRadni = text.ToLower();

            int noSamoglas = 0;

            for (int i = 0; i < textRadni.Length; i++)
            {
                char slovo = textRadni[i];

                if (slovo == 'a' || slovo == 'e' || slovo == 'i' || slovo == 'o' || slovo == 'u')
                {
                    noSamoglas++;
                }

            }
            Console.WriteLine(" u textu ima {0} samoglasnika", noSamoglas);



        }
    }
}
