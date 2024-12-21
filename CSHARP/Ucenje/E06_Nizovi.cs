using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06_Nizovi
    {
        public static void Izvedi()
        {
            int[] temp = new int[12];
            temp[0] = -1;
            temp[1] = 1;
            temp[2] = 2;
            temp[11] = 4;

            Console.WriteLine(temp[0]);
            Console.WriteLine(temp);

            Console.WriteLine(string.Join(",",temp));
            


        }
    }
}
