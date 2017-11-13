using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloweShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalPrice = magnolii * 3.25d + zumbuli * 4 + rozi * 3.5 + kaktusi * 8;
            totalPrice -= totalPrice * 0.05;

            if (totalPrice>=giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalPrice-giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice -totalPrice));
            }
        }
    }
}
