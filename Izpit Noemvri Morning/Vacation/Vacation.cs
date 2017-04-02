using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            var hotel = nights * 82.99;

            if (transport == "train")
            {                
                if (adults + students >= 50)
                {
                    var razhodTransport = ((24.99 - 24.99 * 0.50) * adults + (14.99 - 14.99 * 0.50) * students) * 2;                    
                    var comission = (razhodTransport + hotel) * 0.10;
                    var obshtoRazhod = razhodTransport + hotel + comission;
                    Console.WriteLine("{0:f2}", obshtoRazhod);
                }
                else
                {
                    var razhodTransport = (24.99 * adults + 14.99 * students) * 2;                    
                    var comission = (razhodTransport + hotel) * 0.10;
                    var obshtoRazhod = razhodTransport + hotel + comission;
                    Console.WriteLine("{0:f2}", obshtoRazhod);
                }
            }
            else if (transport == "bus")
            {                
                var razhodTransport = (32.50 * adults + 28.50 * students) * 2;
                var comission = (razhodTransport + hotel) * 0.10;
                var obshtoRazhod = razhodTransport + hotel + comission;
                Console.WriteLine("{0:f2}", obshtoRazhod);
            }
            else if (transport == "boat")
            {
                var razhodTransport = (42.99 * adults + 39.99 * students) * 2;
                var comission = (razhodTransport + hotel) * 0.10;
                var obshtoRazhod = razhodTransport + hotel + comission;
                Console.WriteLine("{0:f2}", obshtoRazhod);
            }
            else if (transport == "airplane")
            {
                var razhodTransport = (70 * adults + 50 * students) * 2;
                var comission = (razhodTransport + hotel) * 0.10;
                var obshtoRazhod = razhodTransport + hotel + comission;
                Console.WriteLine("{0:f2}", obshtoRazhod);
            }
        }
    }
}
