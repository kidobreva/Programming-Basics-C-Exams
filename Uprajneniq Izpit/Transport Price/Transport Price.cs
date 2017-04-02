using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var razstoqnieKm = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            if (razstoqnieKm < 20 && time == "day")
            {
                Console.WriteLine("{0}", 0.70 + razstoqnieKm * 0.79);
            }
            else if (razstoqnieKm < 20 && time == "night")
            {
                Console.WriteLine("{0}", 0.70 + razstoqnieKm * 0.90);
            }            
            else if (razstoqnieKm >= 20 && razstoqnieKm < 100)
            {
                Console.WriteLine(razstoqnieKm * 0.09);
            }
            else if (razstoqnieKm >= 100)
            {
                Console.WriteLine(razstoqnieKm * 0.06);
            }
                  
        }
    }
}
