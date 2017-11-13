using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double juniorsTax = 0.0;
            double seniorsTax = 0.0;

            if (trace == "trail")
            {
                 juniorsTax = juniorBikers * 5.5;
                 seniorsTax = seniorBikers * 7;

            }
            else if (trace == "cross-country")
            {
                if (juniorBikers + seniorBikers >= 50)
                {
                     juniorsTax = juniorBikers * 8;
                     seniorsTax = seniorBikers * 9.5;
                    juniorsTax -= juniorsTax * 0.25;
                    seniorsTax -= seniorsTax * 0.25;
                }
                else
                {
                     juniorsTax = juniorBikers * 8;
                     seniorsTax = seniorBikers * 9.5;
                }
            }
            else if (trace == "downhill")
            {
                 juniorsTax = juniorBikers * 12.25;
                 seniorsTax = seniorBikers * 13.75;

            }
            else if (trace == "road")
            {
                 juniorsTax = juniorBikers * 20;
                 seniorsTax = seniorBikers * 21.50;

            }

            double totalTax = juniorsTax + seniorsTax;
            totalTax -= totalTax * 0.05;

            Console.WriteLine($"{totalTax:F2}");
        }
    }
}
