using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var midDash = 0;
            var outDash = 2 * n - 2;
            var midDash1 = n - 1;
            var outDash1 = n - 1;
            var firstDash = n * 3;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', n * 3), new string('-', midDash), new string('-', outDash));
                midDash++;
                outDash--;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}", new string('*', n * 3), new string('-', n - 1));
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', firstDash), new string('*', midDash1), new string('-', outDash1));
                    break;
                }                    
                Console.WriteLine("{0}*{1}*{2}", new string('-', firstDash), new string('-', midDash1), new string('-', outDash1));
                firstDash--;
                midDash1 += 2;
                outDash1 --; 
                
            }
        }
    }
}
