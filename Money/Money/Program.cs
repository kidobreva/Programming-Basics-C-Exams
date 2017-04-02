using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var numBitcoin = int.Parse(Console.ReadLine());
            var numYoan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine()) / 100;

            var levaBitcoin = numBitcoin * 1168;
            var dollar = numYoan * 0.15;
            var levaDollar = dollar * 1.76;
            var eur = (levaBitcoin + levaDollar) / 1.95;
            var resultAfterChange = eur - (eur * commission);
            Console.WriteLine(resultAfterChange);
        }
    }
}
