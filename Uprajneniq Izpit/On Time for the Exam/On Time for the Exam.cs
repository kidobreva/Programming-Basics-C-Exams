using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var chasIzpit = int.Parse(Console.ReadLine());
            var minIzpit = int.Parse(Console.ReadLine());
            var chasPristigane = int.Parse(Console.ReadLine());
            var minPristigane = int.Parse(Console.ReadLine());

            var nachaloIzpit = chasIzpit * 60 + minIzpit;
            var pristigane = chasPristigane * 60 + minPristigane;
            var razlikaMinuti = pristigane - nachaloIzpit;
            var hours = Math.Abs(razlikaMinuti / 60);
            var mins = Math.Abs(razlikaMinuti % 60);

            if (razlikaMinuti < - 30)
            {
                Console.WriteLine("Early");                
                if (hours == 0)
                    Console.WriteLine("{0} minutes before the start", mins);
                else
                    Console.WriteLine("{0}:{1:D2} hours before the start", hours, mins);
            }
            else if (razlikaMinuti >= -30 && razlikaMinuti <= 0)
            {
                if (hours == 0 && mins == 0)
                    Console.WriteLine("On time");
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", mins);
                }                  
            }
            else if (razlikaMinuti > 0)
            {
                Console.WriteLine("Late");
                if (hours == 0)
                    Console.WriteLine("{0} minutes after the start", mins);
                else
                    Console.WriteLine("{0}:{1:D2} hours after the start", hours, mins);
            }
        }
    }
}
