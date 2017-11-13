using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dotSpaces = (3 * n - 2) / 2;
            int blankSpaces = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dotSpaces));
                Console.Write("/");
                Console.Write(new string(' ', blankSpaces));
                Console.Write("\\");
                Console.WriteLine(new string('.', dotSpaces));

                dotSpaces -= 1; blankSpaces += 2;
            }

            dotSpaces += 1; blankSpaces -= 2;

            Console.Write(new string('.', dotSpaces));
            Console.Write(new string('*', n*2));
            Console.WriteLine(new string('.', dotSpaces));

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.', dotSpaces));
                Console.Write("|");
                Console.Write(new string('\\', blankSpaces));
                Console.Write("|");
                Console.WriteLine(new string('.', dotSpaces));
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', dotSpaces));
                Console.Write("/");
                Console.Write(new string('*', blankSpaces));
                Console.Write("\\");
                Console.WriteLine(new string('.', dotSpaces));

                dotSpaces -= 1; blankSpaces += 2;
            }
        }
    }
}
