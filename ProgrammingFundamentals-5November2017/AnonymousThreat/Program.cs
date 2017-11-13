using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                if (input.Contains("merge"))
                {
                    int[] commands = input.Split().Skip(1).Select(int.Parse).ToArray();
                    int startInd = commands[0];
                    int endInd = commands[1];
                    if (startInd < 0 || startInd >= inputs.Count)
                    {
                        startInd = 0;
                    }

                    if (endInd >= inputs.Count || endInd < 0)
                    {
                        endInd = inputs.Count - 1;
                    }


                    StringBuilder sb = new StringBuilder();
                    for (int i = startInd; i <= endInd; i++)
                    {
                        sb.Append(inputs[i]);
                        inputs[i] = "696969696";
                    }

                    inputs[startInd] = sb.ToString();

                    for (int i = 0; i < inputs.Count; i++)
                    {
                        if (inputs[i] == "696969696")
                        {
                            inputs.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else
                {
                    int[] commands = input.Split().Skip(1).Select(int.Parse).ToArray();
                    int Ind = commands[0];
                    int parts = commands[1];
                    List<string> toAdd = Divide(inputs[Ind], parts);
                    inputs.RemoveAt(Ind);
                    inputs.InsertRange(Ind, toAdd);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputs));
        }

        private static List<string> Divide(string v, int parts)
        {
            List<string> list = new List<string>();

            if (v.Length % parts == 0)
            {
                int length = v.Length / parts;
                int toskip = 0;
                while (!(toskip >= v.Length))
                {
                    list.Add(string.Join("", v.Skip(toskip).Take(length).ToArray()));
                    toskip += length;
                }
            }
            else
            {
                int length = v.Length / parts;
                int toskip = 0;
                int i = 0;
                while (!(toskip >= v.Length) && i < parts - 1)
                {
                    list.Add(string.Join("", v.Skip(toskip).Take(length).ToArray()));
                    toskip += length;
                    i++;
                }
                list.Add(string.Join("", v.Skip(toskip).ToArray()));
            }

            return list;
        }
    }
}
