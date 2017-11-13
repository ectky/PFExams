using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            n *= kgVegetables;
            m *= kgFruits;
            Console.WriteLine((n+m)/1.94);
        }
    }
}
