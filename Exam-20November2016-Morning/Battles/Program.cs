using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= first && sum < battles; i++)
            {
                for (int j = 1; j <= second && sum<battles; j++)
                {
                    sum++;
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
