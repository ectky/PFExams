using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long sizeOfField = long.Parse(Console.ReadLine());
            long[] ladybugsIndexes = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int[] ladybugs = new int[sizeOfField];

            for (int i = 0; i < sizeOfField; i++)
            {
                if (ladybugsIndexes.Contains(i))
                {
                    ladybugs[i] = 1;
                }
                else
                {
                    ladybugs[i] = 0;
                }
            }
           

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arr = input.Split(' ');
                long i = long.Parse(arr[0]);
                string command = arr[1];
                long length = long.Parse(arr[2]);

                if (i < sizeOfField && i >= 0 && ladybugs[i] == 1)
                {
                    ladybugs[i] = 0;
                    if (command == "right")
                    {
                        long newI = i + length;
                        if (newI < sizeOfField && newI >= 0)
                        {
                            while (newI < sizeOfField && newI >= 0 && ladybugs[newI] == 1)
                            {
                                newI += length;
                            }
                            if (newI < sizeOfField && newI >= 0)
                            {
                                ladybugs[newI] = 1;
                            }
                        }
                    }
                    else
                    {
                        long newI = i - length;
                        if (newI < sizeOfField && newI >= 0)
                        {
                            while (newI < sizeOfField && newI >= 0 && ladybugs[newI] == 1)
                            {
                                newI -= length;
                            }
                            if (newI >= 0 && newI < sizeOfField)
                            {
                                ladybugs[newI] = 1;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladybugs));

        }
    }
}
