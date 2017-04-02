using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var men = int.Parse(Console.ReadLine());

            if (category == "Normal")
            {
                var ticketsPrice = 249.99 * men;
                if (men >= 50)
                {
                    var moneyLeft = (budget - (budget * 0.25));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 25 && men <= 49)
                {
                    var moneyLeft = (budget - (budget * 0.40));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 10 && men <= 24)
                {
                    var moneyLeft = (budget - (budget * 0.50));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 5 && men <= 9)
                {
                    var moneyLeft = (budget - (budget * 0.60));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 1 && men <= 4)
                {
                    var moneyLeft = (budget - (budget * 0.75));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
            }
            else if (category == "VIP")
            {
                var ticketsPrice = 499.99 * men;
                if (men >= 50)
                {
                    var moneyLeft = (budget - (budget * 0.25));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 25 && men <= 49)
                {
                    var moneyLeft = (budget - (budget * 0.40));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 10 && men <= 24)
                {
                    var moneyLeft = (budget - (budget * 0.50));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 5 && men <= 9)
                {
                    var moneyLeft = (budget - (budget * 0.60));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
                else if (men >= 1 && men <= 4)
                {
                    var moneyLeft = (budget - (budget * 0.75));
                    Console.WriteLine(moneyLeft > ticketsPrice ? $"Yes! You have {(moneyLeft - ticketsPrice):f2} leva left." :
                                      $"Not enough money! You need {(ticketsPrice - moneyLeft):f2} leva.");
                }
            }
        }
    }
}
