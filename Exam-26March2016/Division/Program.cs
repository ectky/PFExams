using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            var sum1 = 0; var p1 = 0.0;
            var sum2 = 0; var p2 = 0.0;
            var sum3 = 0; var p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum1++;
                }
                if (a[i] % 3 == 0)
                {
                    sum2++;
                }
                if (a[i] % 4 == 0)
                {
                    sum3++;
                }
            }
                p1 = (sum1 * 100.0) / n;
                p2 = (sum2 * 100.0) / n;
                p3 = (sum3 * 100.0) / n;

                Console.WriteLine("{0:f2}%",p1);
                Console.WriteLine("{0:f2}%", p2);
                Console.WriteLine("{0:f2}%", p3);
            
        }
    }
}
