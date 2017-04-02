using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = 2 * n - 2;
            var dashes = 1;

            Console.WriteLine("{0}/|\\{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n - 1), new string('*', 3));

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots), new string('-', dashes));
                dots--;
                dashes++;
            }
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
            for (int i = 1; i < 2; i++)
            {
                for (int j = 1; j <= 4 * n + 1; j++)
                {
                    if (j % 2 != 0)
                        Console.Write("*");
                    else
                        Console.Write(".");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}", new string('*', 4 * n + 1));
        }
    }
}
