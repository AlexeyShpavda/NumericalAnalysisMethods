using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steffensen_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Atan(1 / x) - x * x;
        }

        static void Main()
        {
            const double Fault = 0.00005;
            const double X0 = 0.5;

            Method.Function func = F;

            Solution Result = Method.Steffensen(func, X0, Fault);

            Console.WriteLine($"Approximate Root - {Result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {Result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
