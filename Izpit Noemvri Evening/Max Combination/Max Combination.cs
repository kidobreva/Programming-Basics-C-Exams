using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var nachalo = int.Parse(Console.ReadLine());
            var krai = int.Parse(Console.ReadLine());
            var maxKombinacii = int.Parse(Console.ReadLine());
            var num = 0;
            for (int i = nachalo; i <= krai; i++)
            {
                for (int j = nachalo; j <= krai; j++)
                {
                    num = num + 1;

                    if (num > maxKombinacii)
                        break;
                    else
                        Console.Write("<{0}-{1}>", i, j);
                }
            }
            Console.WriteLine();
        }
    }
}
