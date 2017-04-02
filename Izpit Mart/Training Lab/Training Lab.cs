using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            w = w * 100;
            h = h * 100;

            var koloni = Math.Truncate((h - 100) / 70);
            //var koloni = Math.Round(((h - 100) / 70), 0);
           // var redove = Math.Round((w / 120), 0);
            var redove = Math.Truncate(w / 120);

            var brmesta = koloni * redove - 3;
            Console.WriteLine(brmesta);
        }
    }
}
