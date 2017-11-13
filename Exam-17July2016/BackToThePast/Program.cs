using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inherited = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    inherited -= 12000;
                }
                else
                {
                    inherited -= 12000 + 50 * (18 + (i - 1800));
                }
            }

            if (inherited>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",inherited);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(inherited));
            }
        }
    }
}
