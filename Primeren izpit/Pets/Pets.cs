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
            var ostavenaHranaKg = int.Parse(Console.ReadLine());
            var hranazaDenKucheKg = double.Parse(Console.ReadLine());
            var hranazaDenKoteKg = double.Parse(Console.ReadLine());
            var hranazaDenKostenurkaGr = double.Parse(Console.ReadLine());

            var nujnaHranaKuche = broiDni * hranazaDenKucheKg;
            var nujnaHranaKote = broiDni * hranazaDenKoteKg;
            var nujnaHranaKostenurka = (broiDni * hranazaDenKostenurkaGr) / 1000;
            var obshtoHrana = nujnaHranaKuche + nujnaHranaKote + nujnaHranaKostenurka;

            if (obshtoHrana <= ostavenaHranaKg)
                Console.WriteLine("{0} kilos of food left.", Math.Floor(ostavenaHranaKg - obshtoHrana));
            else
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(obshtoHrana - ostavenaHranaKg));
        }
    }
}
