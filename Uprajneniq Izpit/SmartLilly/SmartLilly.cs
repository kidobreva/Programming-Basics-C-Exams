using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            var godiniLili = int.Parse(Console.ReadLine());
            var cenaPeralnq = double.Parse(Console.ReadLine());
            var cenaIgrachka = double.Parse(Console.ReadLine());
            var num = 0.0;
            var num1 = 0.0;
            var pari = 0.0;
            var igrachki = 0.0;
            for (int i = 1; i <= godiniLili; i++)
            {
                if (i % 2 == 0)
                {
                    num = num + 10;
                    pari = pari + num - 1;
                }
                else
                {
                    num1 = num1 + 1;
                    igrachki = num1;
                }                                               
            }
            var pariIgrachki = igrachki * cenaIgrachka;
            var obshtoStpestqvaniq = pari + pariIgrachki;
           
            if (obshtoStpestqvaniq >= cenaPeralnq)
                Console.WriteLine("Yes! {0:f2}", (obshtoStpestqvaniq - cenaPeralnq));
            else
                Console.WriteLine("No! {0:f2}", (cenaPeralnq - obshtoStpestqvaniq));
        }
    }
}
