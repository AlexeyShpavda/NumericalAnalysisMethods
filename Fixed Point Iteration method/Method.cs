using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixed_Point_Iteration_method
{
    static class Method
    {
        public delegate double Function(double x);

        public static Solution FixedPointIteration(Function func, Function funcDerivative,
            double leftBorder, double rightBorder, double fault)
        {
            double x = (leftBorder + rightBorder) / 2;
            uint iterationsNumber = 0;

            Function usedFunction = (double previousX) =>
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
