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
            const double Fault = 0.00001;
            const double X0 = 0.5;

            Func<double, double> func = F;

            Solution result = Method.Steffensen(func, X0, Fault);

            Console.WriteLine($"Approximate Root - {result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
