﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (var i1 = 1; i1 <= n; i1++)            
                for (var i2 = 1; i2 <= n; i2++)                
                    for (var i3 = 'a'; i3 < 'a' + l; i3++)
                        for (var i4 = 'a'; i4 < 'a' + l; i4++)
                            for (var i5 = Math.Max(i1, i2) + 1; i5 <= n; i5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",
                                    i1, i2, i3, i4, i5);
                            }
            Console.WriteLine();
        }
    }
}
