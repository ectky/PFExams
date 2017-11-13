using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int colSize = 5 * n - 2 * n;
            int midSize = 0;
            int endSize = 5 * n -colSize - 2;
            int middle = n/2;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',colSize), new string('-', midSize), new string('-', endSize));
                midSize++;endSize--;
            }

            midSize--;endSize++;

            for (int row = 1; row <= middle; row++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', colSize), new string('-', midSize), new string('-', endSize));
            }

            for (int row = middle; row > 1; row--)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', colSize), new string('-', midSize), new string('-', endSize));
                colSize--; midSize+=2; endSize--;
            }

            Console.WriteLine("{0}*{1}*{2}", new string('-', colSize), new string('*', midSize), new string('-', endSize));

        }
    }
}
