using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayNumber = int.Parse(Console.ReadLine());
            var doktors = 7;
            var treatedPatients = 0;
            var untreatedPatients = 0;


            for (int i = 1; i <= dayNumber; i++)
            {
                var patientNumber = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                    doktors++;
                if (patientNumber <= doktors)
                    treatedPatients = treatedPatients + patientNumber;
                else
                {
                    treatedPatients = treatedPatients + doktors;
                    var patient = patientNumber - doktors;
                    untreatedPatients = untreatedPatients + patient;
                }
                                   
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
