using System;

namespace Bisection_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Exp(x) + 1 - Math.Sqrt(9 - x * x);
        }

        static void Main()
        {
            const double Fault = 0.00001;
            const double LeftBorder = 0;
            const double RightBorder = 1;

            Func<double, double> func = F;

            Solution result = Method.BisectionMethod(func, LeftBorder, RightBorder, Fault);

            Console.WriteLine($"Approximate Root - {result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}