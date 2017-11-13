using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legionsWithActivity = new Dictionary<string, int>();
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Soldier s = ReadSoldier(input);
                if (!legionsWithActivity.ContainsKey(s.LegionName))
                {
                    legionsWithActivity.Add(s.LegionName, new int());
                    legionsWithSoldiers.Add(s.LegionName, new Dictionary<string, long>());
                }
                if (!legionsWithSoldiers[s.LegionName].ContainsKey(s.SoldierType))
                {
                    legionsWithSoldiers[s.LegionName].Add(s.SoldierType, new long());
                }
                legionsWithSoldiers[s.LegionName][s.SoldierType] += s.SoldierCount;
                if (legionsWithActivity[s.LegionName] < s.LastActivity)
                {
                    legionsWithActivity[s.LegionName] = s.LastActivity;
                }
            }
            string command = Console.ReadLine();

            PrintArmada(command, legionsWithSoldiers , legionsWithActivity);
        }

        private static void PrintArmada(string command, 
            Dictionary<string, Dictionary<string, long>> legionsWithSoldiers, 
            Dictionary<string, int> legionsWithActivity)
        {
            string pattern = @"([0-9]+)\\(.+)";

            if (Regex.IsMatch(command, pattern))
            {
                Match m = Regex.Match(command, pattern);
                string sType = m.Groups[2].Value;
                long activity = long.Parse(m.Groups[1].Value);
                foreach (var pair in legionsWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(sType))
                    .OrderByDescending(legion => legion.Value[sType]))
                {
                    if (legionsWithActivity[pair.Key] < activity)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value[sType]}");
                    }
                }
            }
            else
            {
                string sType = command;
                foreach (var pair in legionsWithActivity.OrderByDescending(p => p.Value))
                {
                    if (legionsWithSoldiers[pair.Key].ContainsKey(sType))
                    {
                        Console.WriteLine($"{pair.Value} : {pair.Key}");
                    }
                }
            }
        }

        public static Soldier ReadSoldier(string input)
        {
            string pattern = @"([0-9]+) = (.+) -> (.+):([0-9]+)";
            Match m = Regex.Match(input, pattern);
            Soldier s = new Soldier();
            s.LastActivity = int.Parse(m.Groups[1].Value);
            s.LegionName = m.Groups[2].Value;
            s.SoldierType = m.Groups[3].Value;
            s.SoldierCount = int.Parse(m.Groups[4].Value);
            return s;
        }
    }
    
    public class Soldier
    {
        public int LastActivity { get; set; }
        public string LegionName { get; set; }
        public string SoldierType { get; set; }
        public int SoldierCount { get; set; }
    }
}
