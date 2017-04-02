using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    var summerBudget = (budget * 30) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", summerBudget);
                }
                else if (season == "winter")
                {
                    var winterBudget = (budget * 70) / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", winterBudget);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    var summerBudget = (budget * 40) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", summerBudget);
                }
                else if (season == "winter")
                    {
                    var winterBudget = (budget * 80) / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", winterBudget);
                }
            }
            else
            {
                var seasonBudget = (budget * 90) / 100;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", seasonBudget);
            }

            }
        }
    }

