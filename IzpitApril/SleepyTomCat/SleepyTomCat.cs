using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            var freeDays = int.Parse(Console.ReadLine());
            var daysInYear = 365;
            var sleepMinsYear = 30000;
            var workPlayTime = 63;
            var freePlayTime = 127;

            var workDays = daysInYear - freeDays;
            var realPlayTime = workDays * workPlayTime + freeDays * freePlayTime;
            var differenceOfNorm = sleepMinsYear - realPlayTime;
            var hours = Math.Abs(differenceOfNorm / 60);
            var mins = Math.Abs(differenceOfNorm % 60);

            if (realPlayTime <= sleepMinsYear)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);            
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);
            }
        }
    }
}
