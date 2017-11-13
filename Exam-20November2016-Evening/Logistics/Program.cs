using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int load = int.Parse(Console.ReadLine());
            int tons = 0;
            double price = 0;
            double average = 0;
            double all = 0;
            double microbus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 0; i < load; i++)
            {
                tons = int.Parse(Console.ReadLine());
                all += tons;

                if (tons <= 3)
                {
                    price = 200;
                    microbus+=tons;
                }
                else if (tons > 3 && tons <= 11)
                {
                    price = 175;
                    truck += tons;
                }
                else
                {
                    price = 120;
                    train += tons;
                }

                average += tons * price;
            }

            average /= all;
            microbus = (microbus / all) * 100;
            truck = (truck / all) * 100;
            train = (train / all) * 100;

            Console.WriteLine($"{average:F2}");
            Console.WriteLine($"{microbus:F2}%");
            Console.WriteLine($"{truck:F2}%");
            Console.WriteLine($"{train:F2}%");

        }
    }
}
