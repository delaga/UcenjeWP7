﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08forPetlja
    {
        public static void Run()
        {
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");

            Console.WriteLine("-------------");
            
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Osijek");
            }

            Console.WriteLine("-------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ispisi {0}",i+1);
            }
            //int suma = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    suma += i;
            //    Console.WriteLine("{0} + {1}={2}",suma-1,i,suma);

            //}
            //Console.WriteLine(suma);


            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            int odKuda = 2, doKuda = 20, uvecanje = 3;
            for (int i=odKuda; i<=doKuda; i+=uvecanje)
            {
                Console.WriteLine(i);
            
            }

            int[] niz = { 2, 3, 4, 5, 3, 2, 2, 2 };

            Console.WriteLine(niz[3]);

            Console.WriteLine("**************");

            for(int i=0;i<niz.Length;i++)
            {
                Console.WriteLine(niz[i]);

            }

            Console.WriteLine("**************");

            int redaka = 8;
            int stupaca = 6;


            for (int i = 0; i < redaka; i++)
            {

                for (int j = 0; j < stupaca; j++)
                {
                    Console.Write("{0,4} ", (i+1) * (j+1));
                
                }
                Console.WriteLine();

            }

            Console.WriteLine("**************");

            for (int i = 0; i < 10; i++)

            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine("Reserva {0}. mjesto",i+1);
            }

            Console.WriteLine("**************");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            int brojZaProvjeru = 157;
            int brojIteracija=1;
            bool prim = true;

            for (int i = 2; i < brojZaProvjeru; i++)
            {
                Console.WriteLine("{0}%{1}=={2} {3}", brojZaProvjeru, i, brojZaProvjeru%i,brojIteracija++);
                if (brojZaProvjeru % i == 0)
                {
                    prim=false;
                    break;
                }
            }
            Console.WriteLine("{0} {1} prim broj", brojZaProvjeru, prim ? "je":"nije");

            for (int i = 0; i > -1; i++)
                {
                break;
            }

            //for (; ; )
            //{
            //    Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} ", new Random().Next());
            //}





        }
    }
}
