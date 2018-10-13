using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Newton_method
{
    static class Method
    {
        public delegate double Function(double x);

        public static Solution SimplifiedNewton(Function func, Function funcDerivative, double x, double fault)
        {
            uint iterationsNumber = 0;
            double x0 = x;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - func(x) / funcDerivative(x0);
                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
