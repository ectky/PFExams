using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            var workDays =days - days * 0.1;
            var workHours = workDays * 8;
            var overtimeHours = overtimeWorkers * 2 * days;
            workHours += overtimeHours;
            workHours = Math.Floor(workHours);

            if (workHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", workHours - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",hours-workHours);
            }

        }
    }
}
