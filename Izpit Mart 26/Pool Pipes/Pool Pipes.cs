using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            decimal hour = decimal.Parse(Console.ReadLine());

            var waterInPipe1 = p1 * hour;
            var waterInPipe2 = p2 * hour;
            var waterInPipes = waterInPipe1 + waterInPipe2;

            if (waterInPipes <= v)
            {
                var poolDebit = Math.Floor((waterInPipes / v) * 100);
                var pipe1Debit = Math.Floor((waterInPipe1 / waterInPipes) * 100);
                var pipe2Debit = Math.Floor((waterInPipe2 / waterInPipes) * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolDebit, pipe1Debit, pipe2Debit);
            }
            else
            {
                var overLiters = waterInPipes - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour, overLiters);
            }

        }
    }
}
