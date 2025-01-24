using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17klasaObjekt
{
    public class Osoba
    {
        public int Sifra { get; set; }

        public string? Ime { get; set; }

        public string Prezime { get; set; } = "";

        public DateTime DatumRodjenja { get; set; }

        public Mjesto Mjesto { get; set; } = new Mjesto();

        public Mjesto[]? Mjesta  { get; set; }


        /// <summary>
        /// Ludilo brale
        /// </summary>
        /// <returns></returns>
        public string ImePrezime()
        {
            NeVidiSeIzvana();
            return Ime + " " + Prezime;

        }

        private string NeVidiSeIzvana ()
        {
            return "";

        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

    }
}
