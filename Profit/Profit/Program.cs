using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var currency = double.Parse(Console.ReadLine());
            var msalary = n * m;
            var yprofit = msalary * 12 + msalary * 2.5;
            var netprofit = (yprofit - yprofit * 0.25) * currency;
            var dprofit = netprofit / 365;
            Console.WriteLine(Math.Round(dprofit, 2));
                        
        }
    }
}
