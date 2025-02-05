using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18Nasljedjivanje
{
    public class Smjer : Entitet
    {

        public string?  Naziv { get; set; }

        public Smjer()
        {
            Console.WriteLine("Pozivam kons");
        }

        private void TestNacinaPristupa()
        {

            Sifra = 1;


            
        }


    }
}
