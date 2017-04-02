using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var avtomobil = 0.0;
            var mikrobus = 0.0;
            var malakAvtobus = 0.0;
            var golqmAvtobus = 0.0;
            var vlak = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                {
                    if (num <= 5)
                        avtomobil = avtomobil + num;
                    if (num >= 6 && num <= 12)
                        mikrobus = mikrobus + num;
                    if (num >= 13 && num <= 25)
                        malakAvtobus = malakAvtobus + num;
                    if (num >= 26 && num <= 40)
                        golqmAvtobus = golqmAvtobus + num;
                    if (num >= 41)
                        vlak = vlak + num;
                }                
            }
            var vsichkiHora = avtomobil + mikrobus + malakAvtobus + golqmAvtobus + vlak;
            //Console.WriteLine(vsichkiHora);
            avtomobil = (avtomobil / vsichkiHora) * 100;
            Console.WriteLine("{0:f2}%", avtomobil);

            mikrobus = (mikrobus / vsichkiHora) * 100;
            Console.WriteLine("{0:f2}%", mikrobus);

            malakAvtobus = (malakAvtobus / vsichkiHora) * 100;
            Console.WriteLine("{0:f2}%", malakAvtobus);

            golqmAvtobus = (golqmAvtobus / vsichkiHora) * 100;
            Console.WriteLine("{0:f2}%", golqmAvtobus);

            vlak = (vlak / vsichkiHora) * 100;
            Console.WriteLine("{0:f2}%", vlak);
        }
    }
}
