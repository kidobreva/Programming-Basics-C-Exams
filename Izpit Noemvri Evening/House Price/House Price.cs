using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var ploshtNaiMalkaStaq = double.Parse(Console.ReadLine());
            var ploshtKuhnq = double.Parse(Console.ReadLine());
            var cenaKvadratenMetyr = double.Parse(Console.ReadLine());

            var ploshtVtoraStaq = ploshtNaiMalkaStaq + ploshtNaiMalkaStaq * 0.10;
            var ploshtTretaStaq = ploshtVtoraStaq + ploshtVtoraStaq * 0.10;
            var ploshtBanq = ploshtNaiMalkaStaq / 2;
            var obshtaPloshtStai = ploshtNaiMalkaStaq + ploshtKuhnq + ploshtVtoraStaq + ploshtTretaStaq + ploshtBanq;
            var obshtaPlosht = obshtaPloshtStai + obshtaPloshtStai * 0.05;
            var cena = obshtaPlosht * cenaKvadratenMetyr;

            Console.WriteLine("{0:f2}", cena);
        }
    }
}
