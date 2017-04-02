using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Operatoins
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var symbol = Console.ReadLine();

            if (symbol == "+")
            {
                //var result = n1 + n2;
                //{
                //    if (result % 2 == 0)
                //        Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                //    else
                //        Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                //}
                
                
                    Console.Write($"{n1} + {n2} = {n1 + n2} - ");
                    Console.WriteLine((n1 + n2) % 2 == 0 ? "even" : "odd");
                
            }
            else if (symbol == "-")
            {
                var result = n1 - n2;
                if (result % 2 == 0)
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                else
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
            }
            else if (symbol == "*")
            {
                var result = n1 * n2;
                if (result % 2 == 0)
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                else
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
            }
            else if (symbol == "/")
            {
                //double result = (double)firstNumber / (double)secondNumber;
                Console.WriteLine(n2 == 0 ? $"Cannot divide {n1} by zero"
                : $"{n1} / {n2} = {(double)n1 / n2:f2}");
            }
            else if (symbol == "%")
            {
               Console.WriteLine(n2 == 0 ? $"Cannot divide {n1} by zero" : $"{n1} % {n2} = {n1 % n2}");
            }
        }
    }
}
