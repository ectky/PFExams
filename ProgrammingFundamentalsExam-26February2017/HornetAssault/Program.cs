using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                long sum = hornets.Sum();
                if (hornets.Count == 0)
                {
                    break;
                }
                if (beehives[i] < sum)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= sum;
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(h => h > 0)));
            }
        }
    }
}
