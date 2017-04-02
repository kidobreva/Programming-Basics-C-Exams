using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var ploshtStranichnaStena = x * y;
            var prozorec = 1.5 * 1.5;
            var ploshtStranici = 2 * ploshtStranichnaStena - 2 * prozorec;
            var zadnaStena = x * x;
            var vrata = 1.2 * 2;
            var ploshtPrednaZadnaStena = 2 * zadnaStena - vrata;
            var obshtoPlosht = ploshtStranici + ploshtPrednaZadnaStena;
            var zelenaBoq = obshtoPlosht / 3.4;
            Console.WriteLine("{0:F2}", zelenaBoq);

            var ploshtPravoygylniciPokriv = 2 * x * y;
            var ploshtTriygynikPokriv = x * h / 2;
            var ploshtTriygynici = 2 * ploshtTriygynikPokriv;
            var obshtoPloshtPokriv = ploshtPravoygylniciPokriv + ploshtTriygynici;
            var chervenaBoq = obshtoPloshtPokriv / 4.3;
            Console.WriteLine("{0:F2}", chervenaBoq);




        }
    }
}
