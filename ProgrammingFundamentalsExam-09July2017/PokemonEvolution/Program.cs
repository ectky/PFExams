using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(.+) -> (.+) -> (.+)";
            var pokemons = new Dictionary<string, List<Evolution>>();

            while (input != "wubbalubbadubdub")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match m = Regex.Match(input, pattern);
                    Evolution e = new Evolution();
                    e.Type = m.Groups[2].Value;
                    e.Index = long.Parse(m.Groups[3].Value);
                    string name = m.Groups[1].Value;
                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons.Add(name, new List<Evolution>());
                    }
                    pokemons[name].Add(e);
                }
                else
                {
                    string name = input;
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var e in pokemons[name])
                        {
                            Console.WriteLine($"{e.Type} <-> {e.Index}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var p in pokemons)
            {
                Console.WriteLine($"# {p.Key}");
                foreach (var e in pokemons[p.Key].OrderByDescending(ev => ev.Index))
                {
                    Console.WriteLine($"{e.Type} <-> {e.Index}");
                }
            }

        }// 78492
    }

    public class Evolution
    {
        public string Type { get; set; }
        public long Index { get; set; }
    }
}
