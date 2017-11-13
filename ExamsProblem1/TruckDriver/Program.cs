using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = decimal.Parse(Console.ReadLine());

            var price = 0.0m;
            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                price = kmPerMonth * 1.45m;
            else if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                    price = kmPerMonth * 0.75m;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    price = kmPerMonth * 0.95m;
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                    price = kmPerMonth * 0.9m;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    price = kmPerMonth * 1.1m;
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                    price = kmPerMonth * 1.05m;
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    price = kmPerMonth *1.25m;
            }

            var finalPrice = price * 4 - price * 4 * 0.1m;
            Console.WriteLine("{0:f2}",finalPrice);
        }
    }
}
