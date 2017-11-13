using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int moves = 0;
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >=1; j--)
                {
                    moves++;
                    sum += (i * 2 + j * 3);
                    if (sum>=controlNumber)
                    {
                        break;
                    }
                }
                if (sum >= controlNumber)
                {
                    break;
                }
            }

            Console.WriteLine("{0} moves",moves);
            if (sum >= controlNumber)
            {
                Console.WriteLine("Score: {0} >= {1}",sum,controlNumber);
            }
        }
    }
}
