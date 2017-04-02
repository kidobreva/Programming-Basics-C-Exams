using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var roof = n / 2;
            var mid = 2 * n - 2 * roof - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', roof), new string('_', mid));

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }

            Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', mid));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', mid));
        }
    }
}
