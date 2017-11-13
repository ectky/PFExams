using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstPoint = 0;
            int secondPoint = 2 * n;

            Console.WriteLine("+{0}+{1}",new string ('~',n-2),new string('.', 2 * n + 1));

            for (int row = 2; row <= (4*n+4)/2; row++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', firstPoint), new string('~', n - 2), new string('.', secondPoint));
                firstPoint++; secondPoint--;
            }

            secondPoint = firstPoint - 1; firstPoint = 0;
            for (int row = (4 * n + 4) / 2; row >= 2; row--)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', firstPoint), new string('.', secondPoint), new string('~', n - 2));
                firstPoint++; secondPoint--;
            }

            Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1),new string('~', n - 2) );

        }
    }
}
