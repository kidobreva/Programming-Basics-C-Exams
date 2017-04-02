using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var kategoriq = Console.ReadLine();
            var broiHora = int.Parse(Console.ReadLine());

            if (kategoriq == "VIP" && broiHora >= 1 && broiHora <= 4)
            {
                budjet = budjet - budjet * 0.75;
                var cenaBileti = broiHora * 499.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "VIP" && broiHora >= 5 && broiHora <= 9)
            {
                budjet = budjet - budjet * 0.60;
                var cenaBileti = broiHora * 499.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "VIP" && broiHora >= 10 && broiHora <= 24)
            {
                budjet = budjet - budjet * 0.50;
                var cenaBileti = broiHora * 499.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "VIP" && broiHora >= 25 && broiHora <= 49)
            {
                budjet = budjet - budjet * 0.40;
                var cenaBileti = broiHora * 499.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "VIP" && broiHora >= 50)
            {
                budjet = budjet - budjet * 0.25;
                var cenaBileti = broiHora * 499.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "Normal" && broiHora >= 1 && broiHora <= 4)
            {
                budjet = budjet - budjet * 0.75;
                var cenaBileti = broiHora * 249.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "Normal" && broiHora >= 5 && broiHora <= 9)
            {
                budjet = budjet - budjet * 0.60;
                var cenaBileti = broiHora * 249.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "Normal" && broiHora >= 10 && broiHora <= 24)
            {
                budjet = budjet - budjet * 0.50;
                var cenaBileti = broiHora * 249.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "Normal" && broiHora >= 25 && broiHora <= 49)
            {
                budjet = budjet - budjet * 0.40;
                var cenaBileti = broiHora * 249.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
            else if (kategoriq == "Normal" && broiHora >= 50)
            {
                budjet = budjet - budjet * 0.25;
                var cenaBileti = broiHora * 249.99;
                if (budjet >= cenaBileti)
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budjet - cenaBileti);
                else
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", cenaBileti - budjet);
            }
        }
    }
}
