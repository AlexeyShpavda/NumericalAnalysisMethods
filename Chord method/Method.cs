using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chord_method
{
    static class Method
    {
        public static Solution ChordMethod(Func<double, double> func, Func<double, double>
            secondDerivative, double leftBorder, double rightBorder, double fault)
        {
            double solution = (leftBorder + rightBorder) / 2;
            uint iterationsNumber = 0;
            bool isSecondDerivativePositive = secondDerivative(solution) >= 0;
            Func<double, double> usedFunction;

            if (isSecondDerivativePositive)
            {
                usedFunction = (double x) => x - func(x) * (rightBorder - x) / (func(rightBorder) - func(x));
            }
            else
            {
                usedFunction = (double x) => leftBorder - func(leftBorder) * (x - leftBorder) / (func(x) - func(leftBorder));
            }

            while (Math.Abs(func(solution)) > fault)
            {
                solution = usedFunction(solution);
                iterationsNumber++;
            }

            return new Solution(solution, iterationsNumber);
        }
    }
}
