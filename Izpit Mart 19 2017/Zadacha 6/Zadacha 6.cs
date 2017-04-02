using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    count = count + 1;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", count, i, j, magicNumber);
                        return;
                    }                                      
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", count, magicNumber);
        }
    }
}
