using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> pokemons = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long sum = 0;

            while (pokemons.Any())
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    sum += pokemons[0];
                    long element = pokemons[0];
                    pokemons = ChageList(pokemons, element);
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                }
                else if (index > pokemons.Count - 1)
                {
                    sum += pokemons[pokemons.Count - 1];
                    long element = pokemons[pokemons.Count - 1];
                    pokemons = ChageList(pokemons, element);
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                }
                else
                {
                    long element = pokemons[index];
                    sum += element;
                    pokemons.RemoveAt(index);
                    pokemons = ChageList(pokemons, element);
                }
            }

            Console.WriteLine(sum);
        }

        public static List<long> ChageList(List<long> pokemons, long element)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= element)
                {
                    pokemons[i] += element;
                }
                else
                {
                    pokemons[i] -= element;
                }
            }
            return pokemons;
        }
    }
    static class ExtensionMethods
    {
        public static long DecreaseElement(this long value, long element)
        {
            return value - element;
        }

        public static long AddElement(this long value, long element)
        {
            return value + element;
        }
    }
    }
