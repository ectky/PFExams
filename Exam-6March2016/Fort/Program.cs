﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int colSize = n / 2;
            int midSize = n * 2 - 2 * colSize - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\",new string('^',colSize),new string('_',midSize));

            for (int i = 2; i <= n-2; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',n*2-2));
            }

            Console.WriteLine("|{0}{1}{0}|",new string(' ',colSize+1),new string('_',midSize));

            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));
        }
    }
}

