using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var priceStudio = 0.0;
            var priceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceStudio = 50 * nights;
                    priceApartment = 65 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceStudio = (50 - (50 * 0.05)) * nights;
                    priceApartment = 65 * nights;
                }
                else
                {
                    priceStudio = (50 - (50 * 0.3)) * nights;
                    priceApartment = (65 - (65 * 0.1)) * nights;
                }                   
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceStudio = (75.20 - (75.20 * 0.2)) * nights;
                    priceApartment = (68.70 - (68.70 * 0.1)) * nights;
                }
                else
                {
                    priceStudio = 75.20 * nights;
                    priceApartment = 68.70 * nights;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceStudio = 76 * nights;
                    priceApartment = (77 - (77 * 0.1)) * nights;
                }
                else
                {
                    priceStudio = 76 * nights;
                    priceApartment = 77 * nights;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceApartment);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);            
        }
    }
}


//var month = Console.ReadLine();
//var nights = int.Parse(Console.ReadLine());

//double studioPrice = 0;
//double apartmentPrice = 0;

//        switch (month)
//        {
//            case "May":
//            case "October":
//                studioPrice = 50;
//                apartmentPrice = 65;

//                if (nights > 14)
//                {
//                    studioPrice -= 50 * 0.3;
//                    apartmentPrice -= 65 * 0.1;
//                }
//                else if (nights > 7)
//                {
//                    studioPrice -= 50 * 0.05;
//                }
//                break;
//            case "June":
//            case "September":
//                studioPrice = 75.20;
//                apartmentPrice = 68.70;

//                if (nights > 14)
//                {
//                    studioPrice -= 75.20 * 0.2;
//                    apartmentPrice -= 68.70 * 0.1;
//                }
//                break;
//            case "July":
//            case "August":
//                studioPrice = 76;
//                apartmentPrice = 77;

//                if (nights > 14)
//                {
//                    apartmentPrice -= 77 * 0.1;
//                }
//                break;
//        }

//        double totalApartmentPrice = apartmentPrice * nights;
//double totalStudioPrice = studioPrice * nights;

//Console.WriteLine("Apartment: {0:F2} lv.", totalApartmentPrice);
//        Console.WriteLine("Studio: {0:F2} lv.", totalStudioPrice);
//    }
