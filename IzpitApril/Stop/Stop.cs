using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dots = n;
            var line = 2 * n - 1;
            
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', (2 * n + 1)));

            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', dots), new string('_', line));
                dots--;
                line += 2;             
            }
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', 2 * n - 3));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', dots), new string('_', line));
                dots++;
                line -= 2;
            }
        }
    }
}
