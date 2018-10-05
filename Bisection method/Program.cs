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
            const double Fault = 0.00005;
            const double LeftBorder = 0;
            const double RightBorder = 1;

            Methods.Function func = F;

            Tuple<double, double> Result = Methods.BisectionMethod(func, LeftBorder, RightBorder, Fault);

            Console.WriteLine($"Solution - {Result.Item1}");
            Console.WriteLine($"Number of Iterations -  {Result.Item2}");

            Console.ReadKey();
        }
    }
}