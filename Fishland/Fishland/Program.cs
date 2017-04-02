using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main()
        {
            decimal prskumriq = decimal.Parse(Console.ReadLine());
            decimal prcaca = decimal.Parse(Console.ReadLine());
            decimal kgpalamud = decimal.Parse(Console.ReadLine());
            decimal kgsafrid = decimal.Parse(Console.ReadLine());
            var kgmidi = int.Parse(Console.ReadLine());
            //var prmidi = 7.5;
            decimal prpalamud = prskumriq + prskumriq * 0.6m;
            decimal sumpalamud = kgpalamud * prpalamud;
            decimal prsafrid = prcaca + prcaca * 0.8m;
            decimal sumsafrid = (kgsafrid * prsafrid);
            decimal summidi = (kgmidi * 7.5m);
            decimal bills = Math.Round((sumpalamud + sumsafrid + summidi), 2);
            Console.WriteLine("{0:F2}", bills);
            //Console.WriteLine(bills);

        }
    }
}
