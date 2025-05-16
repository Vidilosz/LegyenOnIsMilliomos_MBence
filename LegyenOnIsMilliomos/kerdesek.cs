using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegyenOnIsMilliomos
{
    public class Kerdesek
    {
        public List<Kerdes> MindenKerdes { get; set; }

        public Kerdesek()
        {
            MindenKerdes = new List<Kerdes>();
        }

        public void BetoltKerdesekFajlbol(string filepath)
        {
        }
    }
}
