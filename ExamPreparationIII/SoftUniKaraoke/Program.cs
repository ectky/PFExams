using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string input = Console.ReadLine();
            var results = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                string[] participant = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (participants.Contains(participant[0]))
                {
                    if (songs.Contains(participant[1]))
                    {
                        if (!results.ContainsKey(participant[0]))
                        {
                            results.Add(participant[0], new List<string>());
                        }
                        if (!results[participant[0]].Contains(participant[2]))
                        {
                            results[participant[0]].Add(participant[2]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            if (results.Any())
            {
                foreach (var pair in results.OrderByDescending(p => p.Value.Count()).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value.Count()} awards");
                    foreach (var award in pair.Value.OrderBy(aw => aw))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

        }
    }
}
