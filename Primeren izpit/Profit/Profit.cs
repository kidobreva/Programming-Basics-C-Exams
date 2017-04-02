using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var rabotniDni = int.Parse(Console.ReadLine());
            var parinaDen = double.Parse(Console.ReadLine());
            var dolarLev = double.Parse(Console.ReadLine());

            var mesechnaZaplata = rabotniDni * parinaDen;
            var godishenDohod = mesechnaZaplata * 12 + mesechnaZaplata * 2.5;
            var danak = godishenDohod * 0.25;
            var chistDohodLv = (godishenDohod - danak) * dolarLev;
            var chistaPechalbaNaDen = chistDohodLv / 365;
            Console.WriteLine("{0:f2}", chistaPechalbaNaDen);
        }
    }
}
