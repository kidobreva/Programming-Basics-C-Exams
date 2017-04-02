using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            var daljinam = double.Parse(Console.ReadLine());
            var shirinam = double.Parse(Console.ReadLine());

            var biuraRed = Math.Truncate((shirinam * 100 - 100) / 70); 
            var redove = Math.Truncate((daljinam * 100) / 120);
            var broiMesta = biuraRed * redove - 3;
            Console.WriteLine(broiMesta);
        }
    }
}
