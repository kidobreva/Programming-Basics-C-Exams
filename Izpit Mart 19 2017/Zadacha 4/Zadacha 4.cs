using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiLekcii = int.Parse(Console.ReadLine());
            var zadelenBudget = double.Parse(Console.ReadLine());
            var lektor1 = 0.0;
            var lektor2 = 0.0;
            var lektor3 = 0.0;
            var lektor4 = 0.0;
            var lektor5 = 0.0;
            var others = 0.0;    
            for (int i = 0; i < broiLekcii; i++)
            {
                var name = Console.ReadLine();
                if (name == "Jelev")                
                   lektor1 = lektor1 + 1;                                                     
                if (name == "RoYaL")
                    lektor2 = lektor2 + 1;
                if (name == "Roli")
                    lektor3 = lektor3 + 1;
                if (name == "Trofon")
                    lektor4 = lektor4 + 1;
                if (name == "Sino")
                    lektor5 = lektor5 + 1;
                if (name != "Jelev" && name != "RoYaL" && name != "Roli" && name != "Trofon" && name != "Sino")
                    others = others + 1;
            }
            lektor1 = lektor1 * (zadelenBudget / broiLekcii);
            Console.WriteLine("Jelev salary: {0:f2} lv", lektor1);
            lektor2 = lektor2 * (zadelenBudget / broiLekcii);
            Console.WriteLine("RoYaL salary: {0:f2} lv", lektor2);
            lektor3 = lektor3 * (zadelenBudget / broiLekcii);
            Console.WriteLine("Roli salary: {0:f2} lv", lektor3);
            lektor4 = lektor4 * (zadelenBudget / broiLekcii);
            Console.WriteLine("Trofon salary: {0:f2} lv", lektor4);
            lektor5 = lektor5 * (zadelenBudget / broiLekcii);
            Console.WriteLine("Sino salary: {0:f2} lv", lektor5);
            others = others * (zadelenBudget / broiLekcii);
            Console.WriteLine("Others salary: {0:f2} lv", others);
        }
    }
}
