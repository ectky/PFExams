using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dogDaily = double.Parse(Console.ReadLine());
            var catDaily = double.Parse(Console.ReadLine());
            var turtleDaily = double.Parse(Console.ReadLine());

            var dog = days * dogDaily;
            var cat = days * catDaily;
            var turtle = days * turtleDaily;
            turtle /= 1000;
            var all = dog + cat + turtle;

            if (food>=all)
            {
                Console.WriteLine($"{Math.Floor(food-all)} kilos of food left.");
                
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(all-food)} more kilos of food are needed.");
            }


        }
    }
}
