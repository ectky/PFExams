using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachine = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            var toys = 0;
            var money = 0;
            var ten = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i%2!=0)
                {
                    toys++;
                }
                else
                {
                    money += ten ;
                    ten += 10;
                    money--;
                }
            }

            toysPrice *= toys;
            money += toysPrice;

            if (money>=washingmachine)
            {
                Console.WriteLine("Yes! {0:f2}", money- washingmachine);
            }
            else
                Console.WriteLine("No! {0:f2}", washingmachine- money);
        }
    }
}
