using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = int .Parse(Console.ReadLine());       //var w = double.Parse(Console.ReadLine());
            var l = int .Parse(Console.ReadLine());       //var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());

            var area = n * n;
            var benchArea = m * o;
            var repairArea = area - benchArea;
            var tileArea = w * l;

            var tiles =(double) repairArea / tileArea;    //var tiles = repairArea / tileArea;
            Console.WriteLine(tiles);

            var minutes = tiles * 0.2;
            Console.WriteLine(minutes);

        }
    }
}
