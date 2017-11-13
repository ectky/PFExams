using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var destination = "";
            var sort = "";
            var willSpend = 0.0;
            if(budget<=100)
            {
                destination = "Bulgaria";
                if (season=="summer")
                {
                    sort = "Camp";
                    willSpend = budget * 0.3;
                }
                else if (season=="winter")
                {
                    sort = "Hotel";
                    willSpend = budget * 0.7;
                }
            }
            else if (budget<=1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sort = "Camp";
                    willSpend = budget * 0.4;
                }
                else if (season == "winter")
                {
                    sort = "Hotel";
                    willSpend = budget * 0.8;
                }
            }
            else if (budget >1000)
            {
                sort = "Hotel";
                destination = "Europe";
                willSpend = budget * 0.9;
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}",sort,willSpend);
        }
    }
}
