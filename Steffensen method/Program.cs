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

            Methods.Function func = F;

            Tuple<double, double> Result = Methods.SteffensenMethod(func, X0, Fault);

            Console.WriteLine($"Solution - {Result.Item1}");
            Console.WriteLine($"Number of Iterations -  {Result.Item2}");

            Console.ReadKey();
        }
    }
}
