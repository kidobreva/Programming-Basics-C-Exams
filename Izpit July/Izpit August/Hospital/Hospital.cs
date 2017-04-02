using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            
            var doc = 7;
            var treatedPatients = 0;
            var untreatedPatients = 0;
            var patient = 0;

            for (int i = 1; i <= period; i++)
            {
                //var patient = 0;
                patient = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                    doc = doc + 1;

                if (patient <= 7)
                {                    
                    treatedPatients = treatedPatients + patient;
                }
                
                else
                {                  
                    untreatedPatients = untreatedPatients + patient - doc;
                    treatedPatients = treatedPatients + doc;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}


//var period = int.Parse(Console.ReadLine());

//int treatedPatients = 0;
//int untreatedPatients = 0;
//int countOfDoctors = 7;

//        for (int day = 1; day <= period; day++)
//        {
//            var currentPatients = int.Parse(Console.ReadLine());

//            if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
//            {
//                countOfDoctors++;
//            }

//            if (currentPatients > countOfDoctors)
//            {
//                treatedPatients += countOfDoctors;
//                untreatedPatients += currentPatients - countOfDoctors;
//            }
//            else
//            {
//                treatedPatients += currentPatients;
//            }
//        }

//        Console.WriteLine("Treated patients: {0}.", treatedPatients);
//        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
//    }
//}
