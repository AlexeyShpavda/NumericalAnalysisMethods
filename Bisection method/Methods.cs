using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_method
{
    static class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> BisectionMethod(Function func, double leftBorder, double rightBorder, double fault)
        {
            double solution = (leftBorder + rightBorder) / 2;
            int iterationsNumber = 0;

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

            return new Tuple<double, double>(solution, iterationsNumber);
        }
    }
}
