using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var battlesCount = 0;
            for (int i = 1; i <= p1; i++)
            {
                for (int j = 1; j <= p2; j++)
                {                                        
                    if (battlesCount == b)
                    {
                        break;                       
                    }
                    else
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }
                    battlesCount++;                    
                }
            }
            Console.WriteLine(); 
        }
    }
}
