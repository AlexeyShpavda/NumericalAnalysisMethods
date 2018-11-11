using System;

namespace Bisection_method
{
    static class Method
    {
        public static Solution BisectionMethod(Func<double, double> func, double leftBorder, double rightBorder, double fault)
        {
            double solution = (leftBorder + rightBorder) / 2;
            uint iterationsNumber = 0;

            while (Math.Abs(func(solution)) > fault)
            {
                if (func(leftBorder) * func(solution) > 0)
                {
                    leftBorder = solution;
                }
                else
                {
                    rightBorder = solution;
                }
                solution = (leftBorder + rightBorder) / 2;
                iterationsNumber++;
            }

            return new Solution(solution, iterationsNumber);
        }
    }
}
