using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            x *= y;
            var harvestPerWine =x * 0.4;
            var wine = harvestPerWine / 2.5;

            if (wine >= z)
            {
                var wineLeft = wine - z;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / workers));

            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - wine));
            }
        }
    }
}
