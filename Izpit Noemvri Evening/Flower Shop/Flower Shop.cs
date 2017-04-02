using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiMagnolii = int.Parse(Console.ReadLine());
            var broiZiumbiuli = int.Parse(Console.ReadLine());
            var broiRozi = int.Parse(Console.ReadLine());
            var broiKaktusi = int.Parse(Console.ReadLine());
            var cenaPodaryk = double.Parse(Console.ReadLine());

            var sumaOtPorychka = broiMagnolii * 3.25 + broiZiumbiuli * 4 + broiRozi * 3.5 + broiKaktusi * 8;
            var pechalba = sumaOtPorychka - sumaOtPorychka * 0.05;

            if (pechalba >= cenaPodaryk)
                Console.WriteLine("She is left with {0} leva.", Math.Floor(pechalba - cenaPodaryk));
            else
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(cenaPodaryk - pechalba));
        }
    }
}
