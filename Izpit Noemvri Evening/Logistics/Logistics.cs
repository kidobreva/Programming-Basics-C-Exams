using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            var broiTovari = int.Parse(Console.ReadLine());
            var mikrobus = 0.0;
            var kamion = 0.0;
            var vlak = 0.0;

            for (int i = 0; i < broiTovari; i++)
            {
                var tonajTovar = int.Parse(Console.ReadLine());
                if (tonajTovar <= 3)
                    mikrobus = mikrobus + tonajTovar;
                if (tonajTovar >= 4 && tonajTovar <= 11)
                    kamion = kamion + tonajTovar;
                if (tonajTovar >= 12)
                    vlak = vlak + tonajTovar;
            }
            var vsichkiTovari = mikrobus + kamion + vlak;
            var cenaSrednoNaTon = (mikrobus * 200 + kamion * 175 + vlak * 120) / vsichkiTovari;
            Console.WriteLine("{0:f2}", cenaSrednoNaTon);

            mikrobus = (mikrobus / vsichkiTovari) * 100;
            Console.WriteLine("{0:f2}%", mikrobus);

            kamion = (kamion / vsichkiTovari) * 100;
            Console.WriteLine("{0:f2}%", kamion);

            vlak = (vlak / vsichkiTovari) * 100;
            Console.WriteLine("{0:f2}%", vlak);
        }
    }
}
