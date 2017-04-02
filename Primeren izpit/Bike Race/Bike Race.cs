using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var trase = Console.ReadLine();
            var uchastnici = juniors + seniors;

            if (trase == "trail")
            {
                var sabranaSuma = juniors * 5.5 + seniors * 7;
                var darenaSuma = sabranaSuma - sabranaSuma * 0.05;
                Console.WriteLine("{0:f2}", darenaSuma);
            }
            else if (trase == "cross-country")
            {
                if (uchastnici >= 50)
                {
                    var sabranaSuma = juniors * (8 - 8 * 0.25) + seniors * (9.5 - 9.5 * 0.25);
                    var darenaSuma = sabranaSuma - sabranaSuma * 0.05;
                    Console.WriteLine("{0:f2}", darenaSuma);
                }
                else
                {
                    var sabranaSuma = juniors * 8 + seniors * 9.5;
                    var darenaSuma = sabranaSuma - sabranaSuma * 0.05;
                    Console.WriteLine("{0:f2}", darenaSuma);
                }                
            }
            else if (trase == "downhill")
            {
                var sabranaSuma = juniors * 12.25 + seniors * 13.75;
                var darenaSuma = sabranaSuma - sabranaSuma * 0.05;
                Console.WriteLine("{0:f2}", darenaSuma);
            }
            else if (trase == "road")
            {
                var sabranaSuma = juniors * 20 + seniors * 21.50;
                var darenaSuma = sabranaSuma - sabranaSuma * 0.05;
                Console.WriteLine("{0:f2}", darenaSuma);
            }
        }
    }
}
