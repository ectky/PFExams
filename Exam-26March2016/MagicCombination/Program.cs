using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int forth = 1; forth <= 9; forth++)
                        {
                            for (int fifth = 1; fifth <= 9; fifth++)
                            {
                                for (int sixth = 1; sixth <= 9; sixth++)
                                {
                                    if (first* second* third* forth* fifth* sixth==n)
                                    {
                                        Console.Write($"{first}{second}{third}{forth}{fifth}{sixth} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
