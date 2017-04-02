using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double cenaSkumriqKg = double.Parse(Console.ReadLine());
            double cenaCacaKg = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double cenaPalamud = cenaSkumriqKg + cenaSkumriqKg * 0.60;
            double sumaPalamud = cenaPalamud * kgPalamud;
            double cenaSafrid = cenaCacaKg + cenaCacaKg * 0.80;
            double sumaSafrid = cenaSafrid * kgSafrid;
            double sumaMidi = kgMidi * 7.50;
            double smetka = sumaPalamud + sumaSafrid + sumaMidi;

            Console.WriteLine("{0:f2}", smetka);
        }
    }
}
