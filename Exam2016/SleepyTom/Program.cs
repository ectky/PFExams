using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort freedays = ushort.Parse(Console.ReadLine());
            var playtime = (365-freedays) * 63 + freedays * 127;
            var diff = Math.Abs(30000 - playtime);
            var h = diff / 60;
            var m = diff % 60;
            if (playtime>30000)
                Console.WriteLine("{0} hours and {1} minutes more for play",h,m);
            else
                Console.WriteLine("{0} hours and {1} minutes less for play",h,m);
        }
    }
}
