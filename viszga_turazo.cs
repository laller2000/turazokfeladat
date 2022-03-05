using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizsgatura
{
    class viszga_turazo
    {
        private int id;
        private string vezeteknev;
        private string keresztnev;
        private string varos;
        private string telefonszam;

        public int Id { get => id; set => id = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Varos { get => varos; set => varos = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }

        public viszga_turazo(int id, string vezeteknev, string keresztnev, string varos, string telefonszam)
        {
            Id = id;
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            Varos = varos;
            Telefonszam = telefonszam;
        }
    }
}
