using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());        //kv.m. cqloto loze
            var y = double.Parse(Console.ReadLine());     //grozde za 1km.m
            var z = int.Parse(Console.ReadLine());        //nujni litri vino
            var workers = int.Parse(Console.ReadLine());  //broi rabotnici

            var kgGrapes = x * y;
            var wine = (kgGrapes * 0.4) / 2.5;

            if (wine >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                var leftWine = Math.Ceiling(wine - z);
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                                  leftWine, Math.Ceiling(leftWine / workers));
            }
            else
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - wine));
        }
    }
}
