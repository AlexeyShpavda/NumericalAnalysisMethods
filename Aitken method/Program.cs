using System;

namespace Aitken_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Atan(1 / x) - x * x;
        }

        public static double dF(double x)
        {
            return -2 * x - (1 / ((x * x) * (1 + 1 / (x * x))));
        }

        static void Main()
        {
            const double Fault = 0.00001;
            const double LeftBorder = 0;
            const double RightBorder = 1;

            Func<double, double> func = F;
            Func<double, double> funcDerivative = dF;

            Solution result = Method.Aitken(func, funcDerivative, LeftBorder, RightBorder, Fault);

            Console.WriteLine($"Approximate Root - {result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
