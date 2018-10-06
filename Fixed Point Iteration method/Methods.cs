using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixed_Point_Iteration_method
{
    static class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> FixedPointIterationMethod(Function func, Function funcDerivative, double leftBorder, double rightBorder, double fault)
        {
            double solution = (leftBorder + rightBorder) / 2;
            int iterationsNumber = 0;

            Function usedFunction = (double x) => x - (1 / (funcDerivative(x))) * func(x);

            while (Math.Abs(func(solution)) > fault)
            {
                solution = usedFunction(solution);
                iterationsNumber++;
            }

            return new Tuple<double, double>(solution, iterationsNumber);
        }
    }
}
