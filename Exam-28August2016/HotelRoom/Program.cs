using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            var studio=0.0;
            var apartment = 0.0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (night>7 && night<=14)
                {
                    studio -= studio * 0.05;
                }
                else if (night>14)
                {
                    studio -= studio * 0.3;
                    apartment -= apartment * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.2;
                apartment = 68.7;
                if (night > 14)
                {
                    studio -= studio * 0.2;
                    apartment -= apartment * 0.1;
                }
            }
            else if(month == "August" || month == "July")
            {
                studio = 76;
                apartment = 77;
                if (night > 14)
                {
                    apartment -= apartment * 0.1;
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.",night*apartment);
            Console.WriteLine("Studio: {0:f2} lv.",night*studio);
        }
    }
}
