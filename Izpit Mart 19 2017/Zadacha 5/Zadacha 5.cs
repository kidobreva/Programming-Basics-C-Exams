using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = 2;
            var symbol = 2 * n - 5;
            var dots1 = n - 2;
            var spaces = 1;
            Console.WriteLine("{0}", new string('*', 2 * n + 1));
            Console.WriteLine(".*{0}*.", new string(' ', 2 * n - 3));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('@', symbol));
                dots++;
                symbol -= 2;
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            Console.WriteLine("{0}*@*{0}", new string('.', n - 1));
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', dots1), new string(' ', spaces));
                dots1--;
                spaces++;
            }
            Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
            Console.WriteLine("{0}", new string('*', 2 * n + 1));
        }
    }
}
