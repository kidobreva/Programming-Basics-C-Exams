using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holidayOrNot = Console.ReadLine();
            var price = 0.0;
            var obshtoCvetq = hrizantemi + rozi + laleta;

            if (holidayOrNot == "Y")
            {
                if (season == "Spring" || season == "Summer")
                {
                    price = hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50;
                    price = price + price * 0.15;
                    if (season == "Spring" && laleta > 7)
                    {
                        price = price - price * 0.05;
                    }
                    if (obshtoCvetq >= 20)
                    {
                        price = price - price * 0.20 + 2;
                    }
                    else
                        price = price + 2;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (season == "Autumn" || season == "Winter")
                {
                    price = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    price = price + price * 0.15;
                    if (season == "Winter" && rozi >= 10)
                    {
                        price = price - price * 0.10;
                    }
                    if (obshtoCvetq >= 20)
                    {
                        price = price - price * 0.20 + 2;
                    }
                    else
                        price = price + 2;
                    Console.WriteLine("{0:f2}", price);
                }
            }
            if (holidayOrNot == "N")
            {
                if (season == "Spring" || season == "Summer")
                {
                    price = hrizantemi * 2.00 + rozi * 4.10 + laleta * 2.50;
                    if (season == "Spring" && laleta > 7)
                    {
                        price = price - price * 0.05;
                    }
                    if (obshtoCvetq >= 20)
                    {
                        price = price - price * 0.20 + 2;
                    }
                    else
                        price = price + 2;
                    Console.WriteLine("{0:f2}", price);
                }
                else if (season == "Autumn" || season == "Winter")
                {
                    price = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    if (season == "Winter" && rozi >= 10)
                    {
                        price = price - price * 0.10;
                    }
                    if (obshtoCvetq >= 20)
                    {
                        price = price - price * 0.20 + 2;
                    }
                    else
                        price = price + 2;
                    Console.WriteLine("{0:f2}", price);
                }
            }
            
        }
    }
}
