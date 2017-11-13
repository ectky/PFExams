using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
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
            var sum4 = 0; var p4 = 0.0;
            var sum5 = 0; var p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 200)
                {
                    sum1++;
                }
                else if (a[i] >= 200 && a[i] < 400)
                {
                    sum2++;
                }
                else if (a[i] >= 400 && a[i] < 600)
                {
                    sum3++;
                }
                else if (a[i] >= 600 && a[i] < 800)
                {
                    sum4++;
                }
                else if (a[i] >= 800)
                {
                    sum5++;
                }
            }


                //p1 = sum1 / n * 100.0;
                //p2 = sum2 / n * 100.0;
                //p3 = sum3 / n * 100.0;
                //p4 = sum4 / n * 100.0;
                //p5 = sum5 / n * 100.0;

                Console.WriteLine("{0:f2}", (sum1*100.0 / n));
                Console.WriteLine("{0:f2}", (sum2 * 100.0 / n));
                Console.WriteLine("{0:f2}", (sum3 * 100.0 / n));
                Console.WriteLine("{0:f2}", (sum4 * 100.0 / n));
                Console.WriteLine("{0:f2}", (sum5 * 100.0 / n));

        }
    }
}
