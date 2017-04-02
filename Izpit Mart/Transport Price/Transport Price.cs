using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var taxiDay = 0.79;
            var taxiNight = 0.9;
            var taxBus = 0.09;
            var taxTrain = 0.06;
            if (n < 20 && time == "day")
                Console.WriteLine("{0}", taxiDay * n + 0.7);
            else if (n < 20 && time == "night")
                Console.WriteLine("{0}", taxiNight * n + 0.7);
            else if (n < 100)
                Console.WriteLine(taxBus * n);
            else if (n >= 100)
                Console.WriteLine(taxTrain * n);

        }
    }         
}



        

    

