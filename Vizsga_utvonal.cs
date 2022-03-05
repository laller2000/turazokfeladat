using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgatura
{
    class Vizsga_utvonal
    {
        private int id;
        private int turazoID;
        private string honnan;
        private string hova;
        private int km;

        public int Id { get => id; set => id = value; }
        public int TurazoID { get => turazoID; set => turazoID = value; }
        public string Honnan { get => honnan; set => honnan = value; }
        public string Hova { get => hova; set => hova = value; }
        public int Km { get => km; set => km = value; }

        public Vizsga_utvonal(int id, int turazoID, string honnan, string hova, int km)
        {
            Id = id;
            TurazoID = turazoID;
            Honnan = honnan;
            Hova = hova;
            Km = km;
        }
    }
}
