using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenOnIsMilliomos
{
    public class Kerdes
    {
        public string Szoveg { get; set; }
        public List<string> Valaszok { get; set; } // A, B, C, D
        public string HelyesValasz { get; set; }   // "A", "B", "C", "D"
        public string Kategoria { get; set; }

        public Kerdes(string szoveg, List<string> valaszok, string helyesValasz, string kategoria)
        {
            Szoveg = szoveg;
            Valaszok = valaszok;
            HelyesValasz = helyesValasz;
            Kategoria = kategoria;
        }

        public bool EllenorizValaszt(string valasz)
        {
            return HelyesValasz.Equals(valasz, StringComparison.OrdinalIgnoreCase);
        }
    }
}
