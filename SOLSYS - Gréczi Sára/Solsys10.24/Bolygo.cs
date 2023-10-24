using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solsys10._24
{
    class Bolygo
    {
        public string BolygoNeve { get; set; }
        public int HoldjainakSzama { get; set; }
        public double TerfogatAranya { get; set; }

        public Bolygo(string sor)
        {
            List<string> atmeneti = sor.Split(';').ToList();

            BolygoNeve = atmeneti[0];
            HoldjainakSzama =Convert.ToInt32(atmeneti[1]);
            TerfogatAranya = double.Parse(atmeneti[2].Replace('.', ','));

        }
    }
}
