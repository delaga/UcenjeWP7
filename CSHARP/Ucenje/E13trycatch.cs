using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13trycatch
    {
        public static void Izvedi()
        {
            //int b = 0;

            //while (true)
            //{

            //    Console.WriteLine("Unesi ");

            //    try
            //    {
            //        b = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Niste unijeli ");
            //    }
            //}
            //Console.WriteLine(b);


            //Console.WriteLine("______________");



            int godine = 0;

            string unos;

            int brojz;

            for(; ; )
            {
                pocetak:

                Console.WriteLine("Unesi godine između 1 i 110");
                unos=Console.ReadLine();

                if (unos.Trim() =="")
                {
                    Console.WriteLine("Molim unesite vrijednost");
                    continue;
                }

                try
                {
                    godine=int.Parse(unos);

                    if (godine < 1 || godine > 110)
                    {
                        Console.WriteLine("Zicer nisu godine (1-110)");
                        continue;
                    }
                    break;


                }
                catch 
                {
                    //unos 12o

                    foreach (char znak in unos)
                    {
                        brojz= znak;
                        if((brojz<48 || brojz>57))
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
