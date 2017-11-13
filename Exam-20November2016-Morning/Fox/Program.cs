using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var starSize = 1;
            var dashSize = (2 * n + 3) - 4;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', starSize), new string('-', dashSize));
                starSize++; dashSize -= 2;
            }

            var midStars = n; var sideStars = ((2 * n + 3)-4-n)/2;
            for (int row = 0; row < n/3; row++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', sideStars), new string('*', midStars));
                sideStars++; midStars -= 2;
            }

            dashSize = 1; starSize = (2 * n + 3) - 4;
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dashSize), new string('*', starSize));
                starSize -= 2; dashSize++;
            }
        }
    }
}
