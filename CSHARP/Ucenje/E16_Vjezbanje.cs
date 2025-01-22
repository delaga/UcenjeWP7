using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16_Vjezbanje
    {
        public static void Ajd()
        { 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Dobro vece");
            Console.ResetColor();


            Izbornik();

            Console.WriteLine("Doviđenja");




        }

        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("1. Projeri jel parni ili ne");
            Console.WriteLine("2. Rijec unazad");
            Console.WriteLine("0. Izlaz iz app");
            OdabirOpcijeIzbornika();



        }

        private static void OdabirOpcijeIzbornika()
        {
            switch (E14Metode.UcitajBroj("Odaberi opciju!"))
            {
                case 1:
                    Console.WriteLine("Rjesenje 1");
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    RijecUnazad();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Nije opcija");
                    Izbornik();
                    break;
            }


        }

        private static void RijecUnazad()
        {
            NaslovPrograma("Ispisuje rijec unazad");

            string rijec = E14Metode.UcitajString("Unesi rijec","Nije rijec");

            string cejir="";

            for (int i = rijec.Length - 1; i >= 0; i--)
            {
                cejir += rijec[i];
            }
            Console.WriteLine("Rijec {0} je obrnuto = {1}", rijec, cejir);



        }


        private static char z= '•';

        private static void NaslovPrograma(string v)
        {


            Linija(v.Length + 6);
            Console.WriteLine("{0}{1} {2} {3}{3}",z,z,v,z,z);
            Linija(v.Length+6);

        }

        private static void Linija(int v)
        {
            for (int i = 0; i < v; i++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
        }

        private static void ParnostBroja()
        {
            NaslovPrograma("Da li je parni");

            int broj = E14Metode.UcitajBroj("Unesi broj za provjeru", 1, 100);

            if (broj % 2 == 0)
            {
                Console.WriteLine("Parni je");
            }
            else
            {
                Console.WriteLine("Neparni");
            }
            Console.WriteLine("----------ENDE----------");
        }
    }
}
