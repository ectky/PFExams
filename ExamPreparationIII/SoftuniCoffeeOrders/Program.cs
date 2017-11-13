using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeLeaving = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int numOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int secPerStep = int.Parse(Console.ReadLine()) % 86400;
            int stepsPerSec = numOfSteps * secPerStep;

            int hours = stepsPerSec / 3600;
            int seconds = stepsPerSec % 60;
            while (seconds > 60)
            {
                seconds %= 60;
            }
            int minutes = stepsPerSec / 60;
            while(minutes > 60)
            {
                minutes %= 60;
            }

            int hArrival = timeLeaving[0] + hours;
            int mArrival = timeLeaving[1] + minutes;
            int sArrival = timeLeaving[2] + seconds;
            if (sArrival >= 60)
            {
                mArrival += sArrival / 60;
                sArrival %= 60;
            }
            if (mArrival >= 60)
            {
                hArrival += mArrival / 60;
                mArrival %= 60;
            }
            if (hArrival >= 24)
            {
                hArrival %= 24;
            }
            Console.WriteLine($"Time Arrival: {hArrival:D2}:{mArrival:D2}:{sArrival:D2}");

        }
    }
}
