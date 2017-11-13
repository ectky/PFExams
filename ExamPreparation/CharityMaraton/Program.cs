using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMaraton
{
    class Program
    {
        static void Main(string[] args)
        {
            long maratonDaysCount = long.Parse(Console.ReadLine());
            long runnerCount = long.Parse(Console.ReadLine());
            long avgNumOfLaps = long.Parse(Console.ReadLine());
            long lapLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            if (trackCapacity * maratonDaysCount < runnerCount)
            {
                runnerCount = trackCapacity * maratonDaysCount;
            }

            long totalMeters = runnerCount * avgNumOfLaps * lapLength / 1000;
            double moneyRaised = totalMeters * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
