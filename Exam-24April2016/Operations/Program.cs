using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char o = char.Parse(Console.ReadLine());

            var result = 0.0;
            if (o == '+' || o == '-' || o == '*')
            {
                if (o == '+')
                {
                    result = n1 + n2;
                }
                else if (o == '-')
                {
                    result = n1 - n2;
                }
                else if (o == '*')
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, o, n2, result, "even");
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, o, n2, result, "odd");
                }
            }
            else if (o == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, (double)n1 / n2);
                }
            }
            else if (o == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);
                }
            }
        }
    }
}

