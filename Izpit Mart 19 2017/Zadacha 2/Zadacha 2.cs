using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiChashi = int.Parse(Console.ReadLine());
            var broiRabotnici = int.Parse(Console.ReadLine());
            var rabotniDni = int.Parse(Console.ReadLine());

            var izraboteniChasove = broiRabotnici * rabotniDni * 8;
            var izraboteniChashi = Math.Floor(izraboteniChasove / 5.0);
            
            var pari = 0.0;
            if (broiChashi >= izraboteniChashi)
            {
                pari = (broiChashi - izraboteniChashi) * 4.2;
                Console.WriteLine("Losses: {0:f2}", pari);
            }
            else
            {
                pari = (izraboteniChashi - broiChashi) * 4.2;
                Console.WriteLine("{0:f2} extra money", Math.Abs(pari));
            }
                
        }
    }
}
