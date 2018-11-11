using System;

namespace Simplified_Newton_method
{
    static class Method
    {
        public static Solution SimplifiedNewton(Func<double, double> func, Func<double, double> funcDerivative,
            double x, double fault)
        {
            uint iterationsNumber = 0;
            double x0 = x;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - func(x) / funcDerivative(x0);
                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
