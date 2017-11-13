using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = n *5;
            int colSize =n;
            int midSize =n*2-1;

            Console.WriteLine("{0}{1}{0}",new string('.', n+1),new string('_',n*2+1));

            for (int row = 2; row <= n+1; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string ('.',colSize),new string('_',midSize));
                colSize--; midSize += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_',n+(n-3)));

            colSize = 0;midSize = 4 * n - 1;
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', colSize), new string('_', midSize));
                colSize++; midSize -= 2;
            }
        }
    }
}
