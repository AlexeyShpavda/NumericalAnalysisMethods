using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitken_method
{
    static class Methods
    {
        public delegate double Function(double x);
        private delegate double SpecialFormula();

        public static Tuple<double, double> AitkenMethod(Function func, Function funcDerivative, double leftBorder, double rightBorder, double fault)
        {
            Function usedFunction = (double x) => x - (1 / (funcDerivative(x))) * func(x);

            double x0 = (leftBorder + rightBorder) / 2;
            double x1 = usedFunction(x0);
            double x2 = usedFunction(x1);
            SpecialFormula specialFormula = () => (x0 * x2 - x1 * x1) / (x2 - 2 * x1 + x0);
            double xHatch = specialFormula();
            double solution = usedFunction(xHatch);

            int iterationsNumber = 0;

            while (Math.Abs(func(solution)) > fault)
            {
                x0 = xHatch;
                x2 = usedFunction(x1);
                x1 = solution;
                xHatch = specialFormula();
                solution = usedFunction(xHatch);

                iterationsNumber++;

            }

            return new Tuple<double, double>(solution, iterationsNumber);
        }
    }
}
