using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first < n; first++)
            {
                for (int second = 1; second < n; second++)
                {
                    for (int third = 'a'; third < 97+l; third++)
                    {
                        for (int forth = 'a'; forth < 97+l; forth++)
                        {
                            for (int fifth = 1; fifth <= n ; fifth++)
                            {
                                if (fifth > first && fifth > second)
                                {
                                Console.Write("{0}{1}{2}{3}{4} ",first,second,(char)third,(char)forth,fifth);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
