using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steffensen_method
{
    static class Method
    {
        public delegate double Function(double x);

        public static Solution Steffensen(Function func, double x, double fault)
        {
            ushort iterationsNumber = 0;

            while (Math.Abs(func(x)) > fault)
            {
                x = x - (func(x) * func(x)) / (func(x) - func(x - func(x)));
                iterationsNumber++;
            }

            return new Solution(x, iterationsNumber);
        }
    }
}
