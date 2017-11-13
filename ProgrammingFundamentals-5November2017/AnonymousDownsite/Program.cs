using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWebs = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            decimal totalSiteLosses = 0;
            List<string> sites = new List<string>();

            for (int i = 0; i < numOfWebs; i++)
            {
                string[] input = Console.ReadLine().Split();
                long siteVisits = long.Parse(input[1]);
                decimal sitePricePerVisit = decimal.Parse(input[2]);
                //decimal siteLoss = siteVisits * sitePricePerVisit;
                totalSiteLosses += siteVisits * sitePricePerVisit;
                sites.Add(input[0]);
            }

            Console.WriteLine(string.Join(Environment.NewLine, sites));
            Console.WriteLine($"Total Loss: {totalSiteLosses:F20}");
            //Console.WriteLine($"Security Token: {Math.Pow(securityKey,sites.Count)}");

            BigInteger b = BigInteger.Pow(securityKey, sites.Count);
            Console.WriteLine($"Security Token: {b}");
        }
    }
}
