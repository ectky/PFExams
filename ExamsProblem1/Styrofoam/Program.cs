using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var area = decimal.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());
            var styrofoam = decimal.Parse(Console.ReadLine());
            var price = decimal.Parse(Console.ReadLine());

            var houseArea = area - windows * 2.4m;
            houseArea += houseArea * 0.1m;
            var packets = Math.Ceiling(houseArea / styrofoam);
            var moneyNeeded = packets * price;
            if (moneyNeeded <= budget)
            {
                Console.WriteLine("Spent: {0:f2}", moneyNeeded);
                Console.WriteLine("Left: {0:f2}", budget - moneyNeeded);
            }
            else
                Console.WriteLine("Need more: {0:f2}",moneyNeeded-budget);
        }
    }
}
