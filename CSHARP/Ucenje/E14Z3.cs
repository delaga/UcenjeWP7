using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z3
    {

        public static void Izvedi()
        {
            Console.WriteLine(
                "Dobar dan ja sam {0} {1} i imam {2} godina",
                E14Metode.UcitajString("Unesi ime","mora"),
                E14Metode.UcitajString("Unesi ime", "mora"),
                E14Metode.UcitajBroj
                );
        
        }
    }
}
