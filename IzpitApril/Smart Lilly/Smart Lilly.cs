using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var priceLaundry = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());
            var toys = 0;
            var savings = 0;
            var num = 0;

            for (int i = 1; i <= n; i++)
            {
                //var num = int.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    //num = num + 1;
                    num = num + 10;
                    savings = savings + num;                    
                }
                else
                {
                    toys = toys + 1;
                }
            }
            var takenMoney = n / 2;
            var priceToys = priceToy * toys;
            var savingsLeft = savings + priceToys - takenMoney;

            if (savingsLeft >= priceLaundry)
            Console.WriteLine("Yes! {0:f2}", (savingsLeft - priceLaundry));
            else
            Console.WriteLine("No! {0:f2}", (priceLaundry - savingsLeft));
        }
    }
}


//var age = int.Parse(Console.ReadLine());
//var washingMachinePrice = double.Parse(Console.ReadLine());
//var presentPrice = int.Parse(Console.ReadLine());

//var savings = 0;
//var moneyFromPresents = 0;
//var bonus = 10;
//            for (int i = 1; i <= age; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    savings += bonus;
//                    savings -= 1;
//                    bonus += 10;
//                }
//                else
//                {
//                    moneyFromPresents += presentPrice;
//                }
//            }
			
//            var allMoney = savings + moneyFromPresents;
//            if (allMoney >= washingMachinePrice)
//            {
//                Console.WriteLine("Yes! {0:F2}", allMoney - washingMachinePrice);
//            }
//            else
//            {
//                Console.WriteLine("No! {0:F2}", washingMachinePrice - allMoney);
//            }
