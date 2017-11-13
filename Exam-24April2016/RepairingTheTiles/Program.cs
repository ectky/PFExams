using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            n *= n;
            var bench = m * o;
            n -= bench;
            var tiles = w * l;
            var tilesNeeded = n / tiles;
            var time = tilesNeeded * 0.2;

            Console.WriteLine(tilesNeeded+"\n"+time);
        }
    }
}
