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
        public Kerdes VeletlenKerdes(string kategoria)
        {
            var kategoriabeliek = MindenKerdes.Where(k => k.Kategoria == kategoria).ToList();
            if (kategoriabeliek.Count == 0) return null;

            Random rnd = new Random();
            return kategoriabeliek[rnd.Next(kategoriabeliek.Count)];
        }
    }
}
