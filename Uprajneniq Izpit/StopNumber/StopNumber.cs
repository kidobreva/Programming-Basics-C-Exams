using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (s % 2 == 0 && s % 3 == 0 && i == s)
                    break;
                if (i % 2 == 0 && i % 3 == 0)
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
