using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixed_Point_Iteration_method
{
    static class Method
    {
        public static Solution FixedPointIteration(Func<double, double> func, Func<double, double> funcDerivative,
            double leftBorder, double rightBorder, double fault)
        {
            double x = (leftBorder + rightBorder) / 2;
            uint iterationsNumber = 0;

            Func<double, double> usedFunction = (double previousX) =>
            previousX - (1 / (funcDerivative(previousX))) * func(previousX);

            while (Math.Abs(func(x)) > fault)
            {
                x = usedFunction(x);
                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
