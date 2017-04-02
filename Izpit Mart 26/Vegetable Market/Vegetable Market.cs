using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPriceKg = double.Parse(Console.ReadLine());
            double fruitPriceKg = double.Parse(Console.ReadLine());
            var vegKg = int.Parse(Console.ReadLine());
            var fruitKg = int.Parse(Console.ReadLine());

            var vegetables = vegPriceKg * vegKg;
            var fruits = fruitPriceKg * fruitKg;
            var harvest = vegetables + fruits;

            var havestInEuro = harvest / 1.94;
            Console.WriteLine(havestInEuro);
        }
    }
}
