using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var m = n;
            var num3 = m % 10;
            m = m / 10;
            var num2 = m % 10;
            m = m / 10;
            var num1 = m % 10;
            //Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            for (int row = 0; row < num1 + num2; row++)
            {
                for (int col = 0; col < num1 + num3; col++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - num1;                 
                        Console.Write("{0} ", n);
                    }                       
                    else if (n % 3 == 0)
                    {
                        n = n - num2;                       
                        Console.Write("{0} ", n);
                    }                        
                    else
                    {
                        n = n + num3;                        
                        Console.Write("{0} ", n);
                    }                                            
                }
                Console.WriteLine();

            }
        }
    }
}
