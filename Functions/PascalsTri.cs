using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalDude
{
    class PascalsTri
    {
        public static void Run()
        {
            var steep_ness = 10;

            for (int a = 0; a <= steep_ness; a++)
            {
                for (var lo = 1; lo <= steep_ness - a; lo++)
                    Console.Write("   ");

                for(int x = 0; x <= a; x++)
                {
                    int value = Factori(a) / (Factori(x) * Factori(a - x));
                    var c = value.ToString().PadRight(3, ' ');
                    Console.Write("{0}   ", c);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // Factorial
        static int Factori(int x)
        {
            return x < 0 ? -1 : (x == 1 || x == 0 ? 1 : x * Factori(x - 1));
        }
        
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Run();
        }
    }
}
