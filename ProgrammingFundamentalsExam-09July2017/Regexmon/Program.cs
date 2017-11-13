using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern2 = @"\w+-\w+";
            string pattern1 = @"[^A-Za-z-]+";

            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            int i = 0;

            while (IsRegexMAtch(i, sb))
            {
                if (i % 2 == 0 && Regex.IsMatch(sb.ToString(), pattern1))
                {
                    Match m = Regex.Match(sb.ToString(), pattern1);
                    char first = m.Value[0];
                    int indexOfF = sb.ToString().IndexOf(first);
                    sb.Remove(0, indexOfF + m.Value.Length);
                    Console.WriteLine(m.Value);
                }

                if (i % 2 != 0 && Regex.IsMatch(sb.ToString(), pattern2))
                {
                    Match m = Regex.Match(sb.ToString(), pattern2);
                    char first = m.Value[0];
                    int indexOfF = sb.ToString().IndexOf(first);
                    sb.Remove(0, indexOfF + m.Value.Length);
                    Console.WriteLine(m.Value);
                }
                i++;
            }
        }

        private static bool IsRegexMAtch(int i, StringBuilder sb)
        {
            string pattern2 = @"\w+-\w+";
            string pattern1 = @"[^A-Za-z-]+";
            if (i % 2 == 0)
            {
                return Regex.IsMatch(sb.ToString(), pattern1);
            }
            else
            {
                return Regex.IsMatch(sb.ToString(), pattern2);
            }
        }
    }
}
