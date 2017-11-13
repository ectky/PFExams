using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort v = ushort.Parse(Console.ReadLine());
            ushort p1 = ushort.Parse(Console.ReadLine());
            ushort p2 = ushort.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            var sum = p1*h + p2*h;
            var per = (sum / v)*100 ;
            var per1 = 0.0;
            var per2 = 0.0;

            if (sum <= v)
            {
                per1 = (p1*h / sum) * 100;
                per2 = (p2*h / sum) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Floor(per), Math.Floor(per1), Math.Floor(per2));
            }
            else
            {
                var overfill = sum - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,overfill);
            }
        }
    }
}
