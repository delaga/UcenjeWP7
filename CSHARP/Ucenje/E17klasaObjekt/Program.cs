using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17klasaObjekt
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("17");

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;
            osoba.Ime = "Pero";
            osoba.Prezime = "Periè";
            osoba.DatumRodjenja = new DateTime(2000, 1, 1);

            Console.WriteLine(osoba.Ime);


            Osoba[] osobe = new Osoba[3];

            osobe[0] = osoba;

            osobe[1] = new Osoba  {Ime = "Ana", Prezime="Zimska"};


            Console.WriteLine(osobe[1].Ime);


            Console.WriteLine("*******************");

            Console.WriteLine(osoba.Ime);
            foreach (Osoba vo in osobe)
            {
                Console.WriteLine(vo?.Ime ?? "Nije postavljeno");


            }

            Console.WriteLine(osobe[1].ImePrezime());


            Mjesto mjesto = new() { Naziv="Osijek", PostanskiBroj="31000"};

            osoba.Mjesto = mjesto;

            Console.WriteLine(osoba.Mjesto.Naziv);

            var m= new Mjesto { Naziv = "Zagreb", PostanskiBroj = "10000" };

            osobe[1].Mjesto = m;

            Console.WriteLine(osobe[1].Mjesto.Naziv);


            osobe[2]=new () { Ime = "Ivo",
                              Mjesto = new () 
                              { 
                                  Naziv = "Split"
                              } 
                            };

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,10));
            }

            Console.WriteLine("_________________");

            var o = osobe[2];

            o.Mjesto.Zupanija= new Zupanija { Naziv = "Splitsko-dalmatinska", Zupan=new() { Ime="Marko", Mjesto= new() { Naziv="Sinj"} } };

            Console.WriteLine(o.Mjesto.Zupanija.Zupan.Mjesto.Naziv);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::");



            

        }
    }
}
