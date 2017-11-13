using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int br = 0;

            for (int i = start ; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.Write($"<{i}-{j}>");
                    br++;
                    if (br==max)
                    {
                        break;
                    }
                }
                if (br == max)
                {
                    break;
                }
            }

        }
    }
}
