using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitken_method
{
    static class Method
    {
        public static Solution Aitken(Func<double, double> func, Func<double, double> funcDerivative,
            double leftBorder, double rightBorder, double fault)
        {
            Func<double, double> usedFunction = (double xH) => xH - (1 / (funcDerivative(xH))) * func(xH);

            double x0 = (leftBorder + rightBorder) / 2;
            double x1 = usedFunction(x0);
            double x2 = usedFunction(x1);
            Func<double> specialFormula = () => (x0 * x2 - x1 * x1) / (x2 - 2 * x1 + x0);
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
