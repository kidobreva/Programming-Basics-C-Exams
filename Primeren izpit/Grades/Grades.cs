using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var obshtBroiStudents = int.Parse(Console.ReadLine());
            var student1 = 0.0;
            var student2 = 0.0;
            var student3 = 0.0;
            var student4 = 0.0;
            var avarage = 0.0;

            for (int i = 1; i <= obshtBroiStudents; i++)
            {
                var ocenka = double.Parse(Console.ReadLine());
                if (ocenka >= 5)
                    student1 = student1 + 1;
                if (ocenka >= 4 && ocenka <= 4.99)
                    student2 = student2 + 1;
                if (ocenka >= 3 && ocenka <= 3.99)
                    student3 = student3 + 1;
                if (ocenka >= 2 && ocenka <= 2.99)
                    student4 = student4 + 1;
                avarage = avarage + ocenka;
            }
            student1 = (student1 / obshtBroiStudents) * 100;
            Console.WriteLine("Top students: {0:f2}%", student1);
            student2 = (student2 / obshtBroiStudents) * 100;
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", student2);
            student3 = (student3 / obshtBroiStudents) * 100;
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", student3);
            student4 = (student4 / obshtBroiStudents) * 100;
            Console.WriteLine("Fail: {0:f2}%", student4);
            avarage = avarage / obshtBroiStudents;
            Console.WriteLine("Average: {0:f2}", avarage);
        }
    }
}
