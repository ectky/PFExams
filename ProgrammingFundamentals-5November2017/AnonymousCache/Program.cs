using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var datasets = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            while (input != "thetinggoesskrra")
            {
                if (input.Contains("|"))
                {
                    string[] imp = input
                        .Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    if (datasets.ContainsKey(imp[2]))
                    {
                        datasets[imp[2]].Add(imp[0], long.Parse(imp[1]));
                    }
                    else
                    {
                        if (!cache.ContainsKey(imp[2]))
                        {
                            cache.Add(imp[2], new Dictionary<string, long>());
                        }
                        cache[imp[2]].Add(imp[0], long.Parse(imp[1]));
                    }
                }
                else
                {
                    if (!datasets.ContainsKey(input))
                    {
                        datasets.Add(input, new Dictionary<string, long>());
                    }

                    if (cache.ContainsKey(input))
                    {
                        datasets[input] = cache[input];
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var pair in datasets.OrderByDescending(p => p.Value.Sum(p1 => p1.Value)).Take(1))
            {
                Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value.Sum(p1 => p1.Value)}");
                foreach (var secPair in pair.Value)
                {
                    Console.WriteLine($"$.{secPair.Key}");
                }
            }
        }
    }
}
