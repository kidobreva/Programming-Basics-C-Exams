using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var outsideDots = n - 1;
            var insideDots = 3 * n;
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots), new string('.', insideDots));
                outsideDots -= 1;
                insideDots += 2;
            }
            Console.WriteLine(new string('*', n * 5));
            for (int i = 0; i < 2 * n; i++)
            {
                outsideDots += 1;
                insideDots -= 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', outsideDots), new string('.', insideDots));               
            }
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
        }
    }
}
