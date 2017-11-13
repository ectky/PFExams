using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double km2Price = double.Parse(Console.ReadLine());

            double bathroomArea = smallestRoomArea / 2;
            double secondRoomArea = smallestRoomArea + smallestRoomArea * 0.1;
            double thirdRoomArea = secondRoomArea + secondRoomArea * 0.1;
            double total = smallestRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea;
            total += total * 0.05;

            double totalPrice = total * km2Price;
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
