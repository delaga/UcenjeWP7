﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04_Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Parni");
                
                }

            else { Console.WriteLine("Nije");
            }


            Console.WriteLine("{0}PARAN", broj%2==0 ? "" : "NE");





        }
    } 
}
