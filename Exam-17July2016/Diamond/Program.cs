using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int colSize = n-1;
            int midSize = 3 * n;
            Console.WriteLine("{0}{1}{0}",new string('.',n), new string('*',3*n));

            for (int row = 2; row <= n; row++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.',colSize ), new string('.',midSize ));
                colSize--;midSize += 2;
            }

            Console.WriteLine(new string('*', 5 * n));

            colSize=1; midSize-=2;
            for (int row = (3 * n + 2)-n; row >= 3; row--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', colSize), new string('.', midSize));
                colSize++; midSize -= 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', colSize), new string('*', midSize+2));
        }
    }
}
