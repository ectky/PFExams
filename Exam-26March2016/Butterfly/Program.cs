using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int colSize = n - 2;
            int midSize = n - 1;
            for (int row = 1; row <= colSize; row++)
            {
                if (row % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', colSize));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', colSize));
                }
            }
                Console.WriteLine("{0}@",new string (' ',midSize));
            for (int row = 1; row <= colSize; row++)
            {
                if (row % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', colSize));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', colSize));
                }
            }
        }
    }
}
