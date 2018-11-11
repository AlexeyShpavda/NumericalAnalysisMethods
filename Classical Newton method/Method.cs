using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Classical_Newton_method
{
    class Method
    {
        public static Solution ClassicalNewton(Func<double, double> func,
            Func<double, double> funcDerivative, double x, double fault)
        {
            uint iterationsNumber = 0;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - func(x) / funcDerivative(x);
                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
