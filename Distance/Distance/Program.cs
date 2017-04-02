using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine()) / 60.00;
            var secondTime = int.Parse(Console.ReadLine()) / 60.00;
            var thirdTime = int.Parse(Console.ReadLine()) /60.00;

            var firstDistance = (speed * firstTime);
            var secondDistance = (speed + (speed*0.1)) * secondTime;
            var thirdDistance = ((speed + speed * 0.1) - ((speed + speed * 0.1) * 0.05)) * thirdTime;
            var finalDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:F2}", finalDistance);
           
            //Console.WriteLine(Math.Round(finalDistance, 4));
            //Console.WriteLine(firstDistance);
            //Console.WriteLine(secondDistance);
            //Console.WriteLine(thirdDistance);

            }
    }
}
