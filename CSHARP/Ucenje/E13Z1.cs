using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z1
    {
        public static void Izvedi()
        {
            //int b = 0;

            //while (true)
            //{

            //    Console.WriteLine("Unesi parni broj:");

            //    try
            //    {
            //        b = int.Parse(Console.ReadLine());

            //        if (b % 2 != 0)
            //        {
            //            Console.WriteLine("Nije parni");
            //            continue;
            //        }
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Niste unijeli ");
            //    }
            //}
            //Console.WriteLine(b);
            string unos = "";
            int visina = 0;
            int brojz;

            for(; ; )
            {
                pocetak:
                Console.WriteLine("Unesi visinu izmešu 44");
                try
                {
                    unos = Console.ReadLine();
                    visina = int.Parse(unos);

                    if (visina < 44 || visina > 220)
                    {
                        Console.WriteLine("To nije visina");
                        continue;
                    }
                    break;


                }
                catch
                {
                    //unos 12o

                    foreach (char znak in unos)
                    {
                        brojz = znak;
                        if ((brojz < 48 || brojz > 57))
                        {
                            Console.WriteLine("{0} Nije broj", znak);
                            goto pocetak;
                        }
                    }

                    Console.WriteLine("Nije broj (ne seri)");


                }
            }


        }

    }
}
