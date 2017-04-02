using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sybraniPari = double.Parse(Console.ReadLine());
            var shirinaPod = double.Parse(Console.ReadLine());
            var daljinapod = double.Parse(Console.ReadLine());
            var stranaPlochka = double.Parse(Console.ReadLine());
            var visochinaPlochka = double.Parse(Console.ReadLine());
            var cenaZaPlochka = double.Parse(Console.ReadLine());
            var cenaMaistor = double.Parse(Console.ReadLine());

            var ploshtPod = shirinaPod * daljinapod;
            var ploshtPlochki = (stranaPlochka * visochinaPlochka) / 2;
            var neobhodimiPlochki = Math.Ceiling(ploshtPod / ploshtPlochki) + 5;
            var obshtaSuma = neobhodimiPlochki * cenaZaPlochka + cenaMaistor;

            if (obshtaSuma <= sybraniPari)
                Console.WriteLine("{0:f2} lv left.", sybraniPari - obshtaSuma);
            else
                Console.WriteLine("You'll need {0:f2} lv more.", obshtaSuma - sybraniPari);
        }
    }
}
