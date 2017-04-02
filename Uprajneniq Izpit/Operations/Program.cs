using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var simvol = Console.ReadLine();
            var num = 0.0;

            if (simvol == "+")
            {
                num = n1 + n2;
                if (num % 2 == 0)
                    Console.WriteLine("{0} + {1} = {2} - even", n1, n2, num);
                else
                    Console.WriteLine("{0} + {1} = {2} - odd", n1, n2, num);
            }
            else if (simvol == "-")
            {
                num = n1 - n2;
                if (num % 2 == 0)
                    Console.WriteLine("{0} - {1} = {2} - even", n1, n2, num);
                else
                    Console.WriteLine("{0} - {1} = {2} - odd", n1, n2, num);
            }
            else if (simvol == "*")
            {
                num = n1 * n2;
                if (num % 2 == 0)
                    Console.WriteLine("{0} * {1} = {2} - even", n1, n2, num);
                else
                    Console.WriteLine("{0} * {1} = {2} - odd", n1, n2, num);
            }
            else if (simvol == "/")
            {
                num = (double)n1 / (double)n2;
                if (n2 != 0)
                    Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, num);
                else
                    Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else if (simvol == "%")
            {
                num = (double)n1 % (double)n2;
                if (n2 != 0)
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, num);
                else
                    Console.WriteLine("Cannot divide {0} by zero", n1);
            }
        }
    }
}
