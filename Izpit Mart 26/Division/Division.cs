using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                {
                    if (num % 2 == 0)
                        p1 = p1 + 1;

                    if (num % 3 == 0)
                    p2 = p2 + 1;

                    if (num % 4 == 0)
                    p3 = p3 + 1;
                }
            }
            p1 = (p1 / n) * 100;
            Console.WriteLine("{0:f2}%", p1);

            p2 = (p2 / n) * 100;
            Console.WriteLine("{0:f2}%", p2);

            p3 = (p3 / n) * 100;
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
