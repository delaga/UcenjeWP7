using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18Nasljedjivanje
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("E18");
        }
        public Program(string naslov):this()
        {
            Console.WriteLine(naslov);


            Smjer smjer = new();

            smjer.Sifra = 1;
            smjer.Naziv = "Programiranje";


            var s= new Smjer
            {
                Sifra = 2,
                Naziv = "Web Programiranje"
            };


        }




    }
}
