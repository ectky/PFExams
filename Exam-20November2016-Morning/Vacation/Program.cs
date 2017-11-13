using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var night = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            double oldPrice = old;
            double studentsPrice = students;
            var totalPrice = 0.0;

            if (transport == "train")
            {
                if (old + students >= 50)
                {
                    oldPrice *= (24.99 - 24.99 * 0.5);
                    studentsPrice *= (14.99 - 14.99 * 0.5);
                }
                else
                {
                    oldPrice *= 24.99;
                    studentsPrice *= 14.99;
                }
            }
            else if (transport == "bus")
            {
                oldPrice *= 32.50;
                studentsPrice *= 28.50;
            }
            else if (transport == "boat")
            {
                oldPrice *= 42.99;
                studentsPrice *= 39.99;
            }
            else if (transport == "airplane")
            {
                oldPrice *= 70.00;
                studentsPrice *= 50.00;
            }

            var hotelPrice = night * 82.99;
            var price = (oldPrice + studentsPrice) * 2;
            var comission = (price+hotelPrice)*0.1;
            totalPrice = price + hotelPrice + comission;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
