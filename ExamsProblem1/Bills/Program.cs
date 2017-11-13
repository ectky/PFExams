using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            decimal[] a = new decimal[months];

            var electricity = 0.0m;

            for (int i = 0; i < months; i++)
                a[i] = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < months; i++)
                electricity += a[i];

            var water = months * 20;
            var internet = months * 15;
            var others = 0.0m;

            for (int i = 0; i < months; i++)
                others += (a[i] + 20 + 15) + (a[i] + 20 + 15) * 0.2m;

            var average = (electricity + water + internet + others) / months;

            Console.WriteLine("Electricity: {0:f2} lv",electricity);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", average);
            

        }
    }
}
