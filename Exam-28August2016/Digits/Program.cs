using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = n / 100 + (n / 10) % 10;
            int col = n / 100 + n % 10;
            int newNumber = n;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (newNumber % 5 == 0)
                    {
                        newNumber -= n / 100; Console.Write(newNumber + " ");
                    }
                    else if (newNumber % 3 == 0)
                    {
                        newNumber -= (n / 10) % 10; Console.Write(newNumber + " ");
                    }
                    else
                    {
                        newNumber += n % 10; Console.Write(newNumber + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
