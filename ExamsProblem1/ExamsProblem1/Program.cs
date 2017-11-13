using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = decimal.Parse(Console.ReadLine());
            var kg = decimal.Parse(Console.ReadLine());
            var brak = decimal.Parse(Console.ReadLine());

            var all = area * kg;
            var left = all - brak;
            var rakia = (left*0.45m)/7.5m;
            var profitRakia = rakia * 9.8m;
            var forSale = left * 0.55m ;
            var profitForSale = forSale *1.5m;

            Console.WriteLine("{0:f2}", profitRakia);
            Console.WriteLine("{0:f2}",profitForSale);
        }
    }
}
