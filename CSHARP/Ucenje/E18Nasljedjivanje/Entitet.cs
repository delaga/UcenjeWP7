using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18Nasljedjivanje
{
    //nasljedivanje je OOP tehnika koja omogućuje klasama da nasljeđuju metode i svojstva druge klase
    public class Entitet : Object // Object je bazna klasa za sve klase
    {
        public int Sifra { get; set; }


        public void TestNacinaPristupa()
        {
            Sifra = 1;
        }

    }
}
