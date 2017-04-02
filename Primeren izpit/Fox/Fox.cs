using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            var dashes = 2 * n - 1;
            var stars1 = n / 2;
            var stars2 = n;
            var dashes1 = 1;
            var stars3 = 2 * n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', stars), new string('-', dashes));
                stars = stars + 1;
                dashes = dashes - 2;
            }
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', stars1), new string('*', stars2));
                stars1 = stars1 + 1;
                stars2 = stars2 - 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', dashes1), new string('*', stars3));
                dashes1 = dashes1 + 1;
                stars3 = stars3 - 2;
            }
        }
    }
}
