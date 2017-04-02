using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var workHours = (days - (days * 0.1)) * 8;
            var overtime = workers * days * 2;
            var hours = Math.Floor(workHours + overtime);
            //Console.WriteLine(workHours);

            if (hours >= neededHours)
                Console.WriteLine("Yes!{0} hours left.", hours - neededHours);
            else
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours - hours);
        }
    }
}



//{
//var projectHours = int.Parse(Console.ReadLine());
//var availableDays = int.Parse(Console.ReadLine());
//var overtimeWorkers = int.Parse(Console.ReadLine());

//var workDays = availableDays * 0.90;
//var overtime = overtimeWorkers * 2 * availableDays;

//var workHours = Math.Floor(workDays * 8 + overtime);

        
//        if (projectHours <= workHours)
//        {
//            Console.WriteLine("Yes!{0} hours left.", workHours - projectHours);
//        }
//        else
//        {
//            Console.WriteLine("Not enough time!{0} hours needed.", projectHours - workHours);
//        }
//    }
