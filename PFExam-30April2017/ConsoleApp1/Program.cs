using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            length *= 100;
            double reminderOfDivision = length % width;

            if (reminderOfDivision == 0 || width == 0)
            {
                Console.WriteLine($"{width*length:F2}");
            }
            else
            {
                Console.WriteLine($"{length/width*100:F2}%");
            }
        }
    }
}
