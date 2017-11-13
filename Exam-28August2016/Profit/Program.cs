using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailyPay = double.Parse(Console.ReadLine());
            double dollars = double.Parse(Console.ReadLine());

            var monthPay = workDays * dailyPay;
            var yearPay = monthPay * 12 + monthPay * 2.5;
            var tax = yearPay * 0.25;
            yearPay -= tax;
            var levs = yearPay * dollars;
            var averageDayPay = levs / 365;

            Console.WriteLine("{0:f2}",averageDayPay);
        }
    }
}
