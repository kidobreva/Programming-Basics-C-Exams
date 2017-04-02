using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dotsPokriv = (3 * n - 2) / 2;
            var spaces = 0;
            var dotsOpashka = n / 2;
            var starsOpashka = 2 * n - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsPokriv), new string(' ', spaces));
                dotsPokriv--;
                spaces = spaces + 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', 2 * n - 2));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', dotsOpashka), new string('*', starsOpashka));
                dotsOpashka--;
                starsOpashka = starsOpashka + 2;
            }
        }
    }
}
