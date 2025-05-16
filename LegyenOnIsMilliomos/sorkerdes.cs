using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenOnIsMilliomos
{
    public class Sorkerdes
    {
        public string Kerdes { get; set; }
        public List<string> Valaszok { get; set; }
        public List<int> HelyesSorrend { get; set; } // például: [2, 3, 1, 4]

        public Sorkerdes(string kerdes, List<string> valaszok, List<int> helyesSorrend)
        {
            Kerdes = kerdes;
            Valaszok = valaszok;
            HelyesSorrend = helyesSorrend;
        }

        public bool EllenorizValaszt(List<int> jatekosValasza)
        {
            return HelyesSorrend.SequenceEqual(jatekosValasza);
        }
    }
}
