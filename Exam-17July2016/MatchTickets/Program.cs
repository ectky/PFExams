using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            if (people>=1 && people<=4)
            {
                budget -= budget* 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                budget -= budget* 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                budget -= budget* 0.50;
            }
            else if (people >= 25 && people <= 49)
            {
                budget -= budget * 0.40;
            }
            else if(people>=50)
            {
                budget -= budget * 0.25;
            }

            if (category=="VIP")
            {
                if (budget> 499.99*people)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.",budget-499.99 * people);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99 * people - budget );
                }
            }
            else if(category=="Normal")
            {
                if (budget > 249.99 * people)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.",budget * people - 249.99);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99 *people - budget );
                }
            }
        }
    }
}
