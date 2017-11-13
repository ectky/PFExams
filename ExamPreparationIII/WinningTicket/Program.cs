using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, @"[^,\s]+"))
            {
                if (m.Value.Length == 20)
                {
                    string[] halves = GetHalves(m.Value);
                    if (IsWinning(halves) == "winning")
                    {
                        Console.WriteLine($"ticket \"{m.Value}\" - {GetNumber(halves)}{GetMatch(halves)}");
                    }
                    else if (IsWinning(halves) == "jackpot")
                    {
                        Console.WriteLine($"ticket \"{m.Value}\" - 10{GetMatch(halves)} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{m.Value}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        private static int GetNumber(string[] halves)
        {
            if (Regex.IsMatch(halves[0], @"[$||@||^||#]{9}") &&
                     Regex.IsMatch(halves[1], @"[$||@||^||#]{9}"))
            {
                return 9;
            }
            else if (Regex.IsMatch(halves[0], @"[$||@||^||#]{8}") &&
                     Regex.IsMatch(halves[1], @"[$||@||^||#]{8}"))
            {
                return 8;
            }
            else if (Regex.IsMatch(halves[0], @"[$||@||^||#]{7}") &&
                     Regex.IsMatch(halves[1], @"[$||@||^||#]{7}"))
            {
                return 7;
            }
            else
            {
                return 6;
            }
        }

        private static char GetMatch(string[] halves)
        {
            if (Regex.IsMatch(halves[0], @"[$||@||^||#]{10}") &&
                Regex.IsMatch(halves[1], @"[$||@||^||#]{10}"))
            {
                return Regex.Match(halves[0], @"[$||@||^||#]{10}").Value[0];
            }
            else if (Regex.IsMatch(halves[0], @"[$||@||^||#]{6,9}") &&
                     Regex.IsMatch(halves[1], @"[$||@||^||#]{6,9}"))
            {
                return Regex.Match(halves[0], @"[$||@||^||#]{6,9}").Value[0];
            }
            else
            {
                return ' ';
            }
        }

        private static string IsWinning(string[] halves)
        {
            if (Regex.IsMatch(halves[0], @"[$]{10}") &&
                Regex.IsMatch(halves[1], @"[$]{10}"))
            {
                return "jackpot";
            }
            else if (Regex.IsMatch(halves[0], @"[#]{10}") &&
                Regex.IsMatch(halves[1], @"[#]{10}"))
            {
                return "jackpot";
            }
            else if (Regex.IsMatch(halves[0], @"[\^]{10}") &&
               Regex.IsMatch(halves[1], @"[\^]{10}"))
            {
                return "jackpot";
            }
            else if (Regex.IsMatch(halves[0], @"[@]{10}") &&
               Regex.IsMatch(halves[1], @"[@]{10}"))
            {
                return "jackpot";
            }
            else if (Regex.IsMatch(halves[0], @"[$]{6,9}") &&
                     Regex.IsMatch(halves[1], @"[$]{6,9}"))
            {
                return "winning";
            }
            else if (Regex.IsMatch(halves[0], @"[@]{6,9}") &&
                     Regex.IsMatch(halves[1], @"[@]{6,9}"))
            {
                return "winning";
            }
            else if (Regex.IsMatch(halves[0], @"[#]{6,9}") &&
                    Regex.IsMatch(halves[1], @"[#]{6,9}"))
            {
                return "winning";
            }
            else if (Regex.IsMatch(halves[0], @"[\^]{6,9}") &&
                    Regex.IsMatch(halves[1], @"[\^]{6,9}"))
            {
                return "winning";
            }
            else
            {
                return "loser";
            }
        }

        public static string[] GetHalves(string s)
        {
            string[] halves = { s.Substring(0, 10), s.Substring(10) };
            return halves;
        }
    }
}
