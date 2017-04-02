using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal xsRoom = decimal.Parse(Console.ReadLine());
            decimal kithRoom = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            decimal sRoom = xsRoom + xsRoom * 0.1m;
            decimal mRoom = sRoom + (sRoom * 0.1m);
            decimal bathRoom = xsRoom / 2;
            decimal roomArea = xsRoom + kithRoom + sRoom + mRoom + bathRoom;
            decimal houseArea = roomArea + (roomArea * 0.05m);
            decimal housePrice = houseArea * price;
            Console.WriteLine(Math.Round(housePrice, 2)); 

        }
    }
}
