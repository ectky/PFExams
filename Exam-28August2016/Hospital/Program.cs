using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var untreated = 0;
            var treated = 0;
            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i%3==0)
                {
                    if (untreated>treated)
                    {
                        doctors++;
                    }
                }
                if (patients>doctors)
                {
                    untreated += patients - doctors;
                    treated += doctors;
                }
                else
                {
                    treated += patients;
                }
            }

            Console.WriteLine("Treated patients: {0}.",treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
