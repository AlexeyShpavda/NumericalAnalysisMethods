using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplified_Newton_method
{
    static class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> SimplifiedNewtonMethod(Function func, Function funcDerivative, double x, double fault)
        {
            int iterationsNumber = 0;
            double x0 = x;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - func(x) / funcDerivative(x0);
                iterationsNumber++;
            }

            return new Tuple<double, double>(x, iterationsNumber);
        }
    }
}
