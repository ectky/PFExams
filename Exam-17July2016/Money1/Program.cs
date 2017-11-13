using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double uana = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double levs = bitcoins * 1168;
            double dollars = uana * 0.15;
            levs += dollars * 1.76;
            double euro = levs / 1.95;
            euro -= euro*commission / 100;

            Console.WriteLine(euro);
        }
    }
}
