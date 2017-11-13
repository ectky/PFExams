using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            h -= 1;
            int desks = (int)(h / 70*100);
            int rows = (int)(w / 120 * 100);
            int places = desks * rows - 3;

            Console.WriteLine(places);
        }
    }
}
