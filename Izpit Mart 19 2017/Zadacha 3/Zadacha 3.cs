using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var price = 0.0;
            if (budget <= 1000)
            {
                if (season == "Summer")
                {
                    price = budget * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = budget * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:f2}", price);
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                if (season == "Summer")
                {
                    price = budget * 0.80;
                    Console.WriteLine("Alaska - Hut - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = budget * 0.60;
                    Console.WriteLine("Morocco - Hut - {0:f2}", price);
                }
            }
            else if (budget > 3000)
            {
                if (season == "Summer")
                {
                    price = budget * 0.90;
                    Console.WriteLine("Alaska - Hotel - {0:f2}", price);
                }
                else if (season == "Winter")
                {
                    price = budget * 0.90;
                    Console.WriteLine("Morocco - Hotel - {0:f2}", price);
                }
            }
        }
    }
}
