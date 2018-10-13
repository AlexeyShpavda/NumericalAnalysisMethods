using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Newton_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Exp(x) + 1 - Math.Sqrt(9 - x * x);
        }

        public static double dF(double x)
        {
            return (Math.Exp(x) + (x / Math.Sqrt(9.0 - x * x)));
        }

        static void Main()
        {
            const double Fault = 0.00001;
            const double X0 = 0.5;

            Method.Function func = F;
            Method.Function funcDerivative = dF;

            Solution result = Method.SimplifiedNewton(func, funcDerivative, X0, Fault);

            Console.WriteLine($"Approximate Root - {result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }

    }
}
