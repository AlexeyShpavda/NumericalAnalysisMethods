using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitken_method
{
    static class Method
    {
        public delegate double Function(double x);
        private delegate double SpecialFormula();

        public static Solution Aitken(Function func, Function funcDerivative, double leftBorder, double rightBorder, double fault)
        {
            Function usedFunction = (double xH) => xH - (1 / (funcDerivative(xH))) * func(xH);

            double x0 = (leftBorder + rightBorder) / 2;
            double x1 = usedFunction(x0);
            double x2 = usedFunction(x1);
            SpecialFormula specialFormula = () => (x0 * x2 - x1 * x1) / (x2 - 2 * x1 + x0);
            double xHatch = specialFormula();
            double x = usedFunction(xHatch);

            uint iterationsNumber = 1;

            while (Math.Abs(func(x)) > fault)
            {
                x0 = xHatch;
                x2 = usedFunction(x1);
                x1 = x;
                xHatch = specialFormula();
                x = usedFunction(xHatch);

                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
