using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double palamis = double.Parse(Console.ReadLine());
            double scad= double.Parse(Console.ReadLine());
            double mussels= double.Parse(Console.ReadLine());

            var palamislPrice = mackerel + 0.6 * mackerel;
            var scadPrice = sprat + 0.8 * sprat;
            var musselsTotal = mussels * 7.5;
            var palamisTotal = palamis  *palamislPrice;
            var scadTotal = scad * scadPrice;
            var total = musselsTotal + scadTotal + palamisTotal ;

            Console.WriteLine($"{total:f2}");
        }
    }
}
