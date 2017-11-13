using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"^([0-9]+) \<\-\> ([A-Za-z0-9]+)$";
            string pattern2 = @"^([^0-9]+) \<\-\> ([A-Za-z0-9]+)$";

            var privateMsgs = new List<PrivateMessage>();
            var broadcasts = new List<Broadcast>();

            string input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                if (Regex.IsMatch(input, pattern1))
                {
                    Match m = Regex.Match(input, pattern1);
                    string code = ReverseString(m.Groups[1].Value);
                    string msg = m.Groups[2].Value;
                    PrivateMessage pm = new PrivateMessage();
                    pm.Message = msg;
                    pm.Code = code;
                    privateMsgs.Add(pm);
                }
                else if (Regex.IsMatch(input, pattern2))
                {
                    Match m = Regex.Match(input, pattern2);
                    string frequency = ReverseCharacters(m.Groups[2].Value);
                    string msg = m.Groups[1].Value;
                    Broadcast b = new Broadcast();
                    b.Message = msg;
                    b.Frequency = frequency;
                    broadcasts.Add(b);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine($"{item.Frequency} -> {item.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (privateMsgs.Count > 0)
            {
                foreach (var item in privateMsgs)
                {
                    Console.WriteLine($"{item.Code} -> {item.Message}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        public static string ReverseCharacters(string s)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                {
                    sb2.Append(s[i].ToString().ToLower());
                }
                else if(s[i] >= 97 && s[i] <= 122)
                {
                    sb2.Append(s[i].ToString().ToUpper());
                }
                else
                {
                    sb2.Append(s[i]);
                }
            }
            return sb2.ToString();
        }

        public static string ReverseString(string sb)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = sb.Length - 1; i > -1; i--)
            {
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
    }

    public class Broadcast
    {
        public string Frequency { get; set; }
        public string Message { get; set; }
    }

    public class PrivateMessage
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
