using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(' ');
            double[] trackLayout = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] chackpoints = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int i = 0;

            foreach (var participant in participants)
            {
                double fuel = participant[0];
                for (i = 0; i < trackLayout.Length; i++)
                {
                    if (chackpoints.Contains(i))
                    {
                        fuel += trackLayout[i];
                    }
                    else
                    {
                        fuel -= trackLayout[i];

                    }
                    if (fuel <= 0)
                    {
                        break;
                    }
                }
                if (fuel <= 0)
                {
                    Console.WriteLine($"{participant} - reached {i}");
                }
                else
                {
                    Console.WriteLine($"{participant} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
