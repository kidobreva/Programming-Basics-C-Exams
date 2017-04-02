using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var nachalnaSkorost = int.Parse(Console.ReadLine());
            var parvoVremeMin = int.Parse(Console.ReadLine());
            var vtoroVremeMin = int.Parse(Console.ReadLine());
            var tretoVremeMin = int.Parse(Console.ReadLine());

            var parvoRazstoqnie = nachalnaSkorost * (parvoVremeMin / 60.0);
            var skorostSledUvelichenie = nachalnaSkorost + nachalnaSkorost * 0.10;            
            var vtoroRazstoqnie = skorostSledUvelichenie * (vtoroVremeMin / 60.0);            
            var skorostSledNamalenie = skorostSledUvelichenie - skorostSledUvelichenie * 0.05;
            var tretoRazstoqnie = skorostSledNamalenie * (tretoVremeMin / 60.0);
            
            var obshtoRazstoqnie = parvoRazstoqnie + vtoroRazstoqnie + tretoRazstoqnie;
            Console.WriteLine("{0:f2}", obshtoRazstoqnie);
        } 
    }
}
