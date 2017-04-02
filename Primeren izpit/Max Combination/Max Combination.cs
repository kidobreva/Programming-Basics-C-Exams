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
            var maxBroi = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = nachalo; i <= krai; i++)
            {
                for (int j = nachalo; j <= krai; j++)
                {
                    if (count == maxBroi)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                    count++;     
                }
            }
            Console.WriteLine();
        }
    }
}
