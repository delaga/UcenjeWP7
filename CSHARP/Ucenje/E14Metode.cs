using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Metode
    {
        public static void Izvedi() 
        {


            Tip1();

            Tip2(45);

            Tip2(3, "asd");
            Console.WriteLine(Tip3());

            for (int i = 1; i < 100; i++)
            {
                if (Tip4(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Metoda tipa 1. ne vraća vrijednost i ne prima
        /// -void fora
        /// </summary>
        static void Tip1()
        {
            Console.WriteLine("Ispis iz TIP 1.");
            Console.WriteLine("_______________");
        }


        private static void Tip2(int i) 
        {
            Console.WriteLine("Primio sam {0}",i);
            Console.WriteLine("Uvecan za 10 je {0}",i+10);
            Console.WriteLine("_________________");
        }

        protected static void Tip2(int i, string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine("_________________");
        }

        public static string Tip3()
        {
            return "Nešto";
        }

        public static bool Tip4(int broj) 
        {
            for (int i = 2; i > broj; i++)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int UcitajBroj(string poruka)
        {
            while (true) 
            {
                Console.Write(poruka+": ");
                try
                {
                    return int.Parse(Console.ReadLine());

                }
                catch 
                {
                    Console.WriteLine("Nisi unjeo broj");
                    
                }

            }
            
        
        }
        public static int UcitajBroj(string poruka, int min, int max)
        {
            int i = 0;
            for (; ; )
            {
                Console.WriteLine(poruka+": ");
                try
                {
                    i=int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Nije u rasponu {0} i {1}",min,max);
                        continue;
                    }
                    return i;
                }
                catch 
                {
                    Console.WriteLine("Nije broj");
                }

            }
                        
        }

        public static string UcitajString(string poruka, string greska)
        {
            string s;

            do
            {
                Console.WriteLine(poruka+ ": ");
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine(greska);
                    continue;
                }
                return s;
            } while (true);



            return "";
        }






    }
}
