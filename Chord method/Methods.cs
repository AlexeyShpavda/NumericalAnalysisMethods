using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chord_method
{
    static class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> ChordMethod(Function func, Function secondDerivative, double leftBorder, double rightBorder, double fault)
        {
            double solution = (leftBorder + rightBorder) / 2;
            int iterationsNumber = 0;
            bool isSecondDerivativePositive = secondDerivative(solution) >= 0;
            Function usedFunction;

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

            return new Tuple<double, double>(solution, iterationsNumber);
        }
    }
}
