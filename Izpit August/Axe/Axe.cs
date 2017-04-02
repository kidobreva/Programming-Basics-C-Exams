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
            var mid = 1;
            var rightDash = 2 * n - 3;
            var mid1 = n - 1;
            var rightDash1 = n - 1;
            var leftDash = 3 * n;

            Console.WriteLine("{0}{1}{2}", new string('-', 3 * n), new string('*', 2), new string('-', 2 * n - 2));

            
            
                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', mid), new string('-', rightDash));
                    mid++;
                    rightDash--;
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{1}", new string('*', 3 * n), new string('-', n - 1));
                }
                for (int i = 0; i < n / 2; i++)
                {    
                    if (i < (n / 2 - 1))
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDash), new string('-', mid1), new string('-', rightDash1));
                    mid1 += 2;
                    rightDash1--;
                    leftDash--;
                }
                    else
                    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDash), new string('*', mid1), new string('-', rightDash1));
            }
                //Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('*', n - 1), new string('-', n - 1));
            
            
            //for (int i = 0; i < n / 2; i++)
            //{
            //    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('*', n - 1), new string('-', n - 1));
            ////    Console.WriteLine("{0}*{1}*{1}", new string('*', 3 * n), new string('-', n - 1));

            //}
            ////Console.WriteLine("{0}{1}{2}", new string('-', 3 * n), new string('*', 2), new string('-', 2 * n - 2));
        }
    }
}

