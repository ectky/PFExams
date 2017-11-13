using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            double distance = (n / 1000) * m;
            double flap = n / 100;
            double secs = (n / p) * 5;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{secs + flap} s.");
        }
    }
}
