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
            var midstars1 = n / 2;
            var midstars2 = n;
            var dashes1 = 1;
            var stars1 = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine("{0}\\{1}/{0}", new string('*', stars), new string('-', dashes));
                stars++;
                dashes-= 2;
            }
            for (int i = 0; i < n / 3; i++)           //(n / 2) - 1
            {                             
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', midstars1), new string('*', midstars2));
                midstars1 += 1;
                midstars2 -= 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', dashes1), new string('*', stars1));
                dashes1++;
                stars1-= 2;
            }
        }
    }
}
