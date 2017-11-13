using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double originalValue = n * 0.5;
            int count = 0;

            while (n >= m)
            {
                count++;
                n -= m;
                if (n == originalValue)
                {
                    if (!(y == 0))
                    {
                        n /= y;
                    }
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
