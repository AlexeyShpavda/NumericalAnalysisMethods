using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steffensen_method
{
    static class Methods
    {
        public delegate double Function(double x);

        public static Tuple<double, double> SteffensenMethod(Function func, double x, double fault)
        {
            int iterationsNumber = 0;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - (func(x) * func(x)) / (func(x) - func(x - func(x)));
                iterationsNumber++;
            }

            return new Tuple<double, double>(x, iterationsNumber);
        }
    }
}
