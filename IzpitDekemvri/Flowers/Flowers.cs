using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            var daliEPraznik = Console.ReadLine();

            if (daliEPraznik == "Y")
            {
                if (sezon == "Spring")
                {
                    var cenaCvetq = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;
                    var cenaPraznik = cenaCvetq + cenaCvetq * 0.15;
                    var namalenieBuket = 0.0;
                    if (laleta > 7)
                    {
                        namalenieBuket = cenaPraznik - cenaPraznik * 0.05;
                    }
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", (namalenieBuket - namalenieBuket * 0.20 + 2));
                    }
                    else
                        Console.WriteLine("{0:f2}", namalenieBuket + 2);
                }
                else if (sezon == "Summer")
                {
                    var cenaCvetq = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;
                    var cenaPraznik = cenaCvetq + cenaCvetq * 0.15;
                    
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", cenaPraznik - cenaPraznik * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", cenaPraznik + 2);
                }
                else if (sezon == "Autumn")
                {
                    var cenaCvetq = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    var cenaPraznik = cenaCvetq + cenaCvetq * 0.15;

                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", cenaPraznik - cenaPraznik * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", cenaPraznik + 2);
                }
                else if (sezon == "Winter")
                {
                    var cenaCvetq = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    var cenaPraznik = cenaCvetq + cenaCvetq * 0.15;
                    var namalenieBuket = 0.0;
                    if (rozi >= 10)
                    {
                        namalenieBuket = cenaPraznik - cenaPraznik * 0.10;
                    }
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", namalenieBuket - namalenieBuket * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", namalenieBuket + 2);
                }
            }
            else if (daliEPraznik == "N")
            {
                if (sezon == "Spring")
                {
                    var cenaCvetq = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;                    
                    var namalenieBuket = 0.0;
                    if (laleta > 7)
                    {
                        namalenieBuket = cenaCvetq - cenaCvetq * 0.05;
                    }
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", namalenieBuket - namalenieBuket * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", namalenieBuket + 2);
                }
                else if (sezon == "Summer")
                {
                    var cenaCvetq = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;                   
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", cenaCvetq - cenaCvetq * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", cenaCvetq + 2);
                }
                else if (sezon == "Autumn")
                {
                    var cenaCvetq = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;                    
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", cenaCvetq - cenaCvetq * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", cenaCvetq + 2);
                }
                else if (sezon == "Winter")
                {
                    var cenaCvetq = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;                   
                    var namalenieBuket = 0.0;
                    if (rozi >= 10)
                    {
                        namalenieBuket = cenaCvetq - cenaCvetq * 0.10;
                    }
                    if (hrizantemi + rozi + laleta > 20)
                    {
                        Console.WriteLine("{0:f2}", namalenieBuket - namalenieBuket * 0.20 + 2);
                    }
                    else
                        Console.WriteLine("{0:f2}", namalenieBuket + 2);
                }
            }
        }
    }
}
