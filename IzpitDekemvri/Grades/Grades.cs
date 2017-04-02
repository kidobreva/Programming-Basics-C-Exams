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
            var broiStudenti = int.Parse(Console.ReadLine());
            var student1 = 0.0;
            var student2 = 0.0;
            var student3 = 0.0;
            var student4 = 0.0;
            var average = 0.0;

            for (int i = 0; i < broiStudenti; i++)
            {
                var ocenkaOtIzpita = double.Parse(Console.ReadLine());
               
                if (ocenkaOtIzpita >= 5)
                    student1 = student1 + 1;
                if (ocenkaOtIzpita >= 4 && ocenkaOtIzpita <= 4.99)
                    student2 = student2 + 1;
                if (ocenkaOtIzpita >= 3 && ocenkaOtIzpita <= 3.99)
                    student3 = student3 + 1;
                if (ocenkaOtIzpita < 3)
                    student4 = student4 + 1;
                average = average + ocenkaOtIzpita;
            }
            student1 = (student1 / broiStudenti) * 100;
            Console.WriteLine("Top students: {0:f2}%", student1);
            student2 = (student2 / broiStudenti) * 100;
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", student2);
            student3 = (student3 / broiStudenti) * 100;
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", student3);
            student4 = (student4 / broiStudenti) * 100;
            Console.WriteLine("Fail: {0:f2}%", student4);
            average = average / broiStudenti;
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
