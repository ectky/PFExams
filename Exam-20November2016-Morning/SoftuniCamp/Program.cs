using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            double sum = 0, car = 0, minibus = 0,smallBus=0,bigBus=0,train=0;
            for (int i = 0; i < groups; i++)
            {
                var people = int.Parse(Console.ReadLine());
                sum += people;
                if (people<=5)
                {
                    car += people;
                }
                else if (people>=6 && people<=12)
                {
                    minibus += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    smallBus += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    bigBus += people;
                }
                else
                {
                    train += people;
                }
            }

            car = car / sum * 100;
            minibus = minibus / sum * 100;
            smallBus = smallBus / sum * 100;
            bigBus = bigBus / sum * 100;
            train = train / sum * 100;

            Console.WriteLine("{0:f2}%",car);
            Console.WriteLine("{0:f2}%", minibus);
            Console.WriteLine("{0:f2}%", smallBus);
            Console.WriteLine("{0:f2}%", bigBus);
            Console.WriteLine("{0:f2}%", train);

        }
    }
}
