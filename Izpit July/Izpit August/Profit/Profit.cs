using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollarRate = double.Parse(Console.ReadLine());

            var monthSalary = workDays * moneyPerDay;
            var yearProfit = monthSalary * 12 + monthSalary * 2.5;
            var tax = yearProfit * 0.25;
            var netYearProfit = (yearProfit - tax) * dollarRate;

            Console.WriteLine("{0:f2}", netYearProfit / 365);
        }
    }
}



//{
//var days = int.Parse(Console.ReadLine());
//var money = double.Parse(Console.ReadLine());
//var dollarRate = double.Parse(Console.ReadLine());

//var monthSalary = days * money;
//var moneyPerYear = monthSalary * 12 + monthSalary * 2.5;
//var moneyAfterTaxes = moneyPerYear - 25 * moneyPerYear / 100;

//var averageMoney = moneyAfterTaxes * dollarRate / 365;

//Console.WriteLine("{0:F2}", averageMoney);
//}
