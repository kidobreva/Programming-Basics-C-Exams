using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = n - 2;
            var dashes = n - 2;
            var mid = (2 * n - 2 * dashes - 3);

            for (int i = 1; i <= (n - 2); i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}\\{1}/{0}", new string('-', dashes), new string(' ', mid));
                else 
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', stars), new string(' ', mid));
                //Console.WriteLine();
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
            for (int i = n - 1; i < (2 * (n - 2) + 1); i++)
            //for (int i = 1; i <= (n - 2); i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}/{1}\\{0}", new string('*', stars), new string(' ', mid));
                else
                    Console.WriteLine("{0}/{1}\\{0}", new string('-', dashes), new string(' ', mid));
                //Console.WriteLine();
            }
        }
    }
}
