using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var broiDni = int.Parse(Console.ReadLine());
            var ostavenaHrana = int.Parse(Console.ReadLine());
            var zadenHranaKucheKg = double.Parse(Console.ReadLine());
            var zadenHranaKotkaKg = double.Parse(Console.ReadLine());
            var zadenHranaKostenurkaGr = double.Parse(Console.ReadLine());

            var nujnaHranaKuche = broiDni * zadenHranaKucheKg;
            var nujnaHranaKotka = broiDni * zadenHranaKotkaKg;
            var nujnaHranaKostenurka = broiDni * zadenHranaKostenurkaGr / 1000;
            var obshtoHrana = nujnaHranaKuche + nujnaHranaKotka + nujnaHranaKostenurka;

            if (obshtoHrana <= ostavenaHrana)
                Console.WriteLine("{0} kilos of food left.", Math.Floor(ostavenaHrana - obshtoHrana));
            else
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(obshtoHrana - ostavenaHrana));
        }
    }
}
