using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сlassical_Newton_method
{
    class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> NewtonMethod(Function func, Function funcDerivative, double x, double fault)
        {
            int iterationsNumber = 0;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - func(x) / funcDerivative(x);
                iterationsNumber++;
            }

            return new Tuple<double, double>(x, iterationsNumber);
        }
    }
}
