using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solsys10._24
{
    class Program
    {
        static List<Bolygo> bolygok = new List<Bolygo>();
        static void Main()
        {
            using (var sr = new StreamReader(@"..\..\src\solsys.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new Bolygo(sr.ReadLine()));
                }
            }

            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a rendszerben.");


            var f2 = bolygok.Average(b => b.HoldjainakSzama);
            Console.WriteLine($"3.2: a naprendszerben egy bolygónak átlagosan {f2:0.00} holdja van");

            var Max = bolygok.Max(b => b.TerfogatAranya);
            var f3 = bolygok.SingleOrDefault(b => b.TerfogatAranya == Max);
            Console.WriteLine($"3.3: a legnagyobb bolygó a {f3.BolygoNeve}.");

            Console.Write($"3.4: írd be a keresett bolygó nevét: ");
            string keresett = Console.ReadLine();
            var f4 = bolygok.SingleOrDefault(b => b.BolygoNeve == keresett);
            Console.WriteLine(f4 != null ? "Van ilyen bolygó a naprendszerben.":$"Sajnos nincs ilyen nevű bolygó a naprendszerben.");

            Console.Write("3.5: Írj be egy egész számot: ");
            keresett = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
