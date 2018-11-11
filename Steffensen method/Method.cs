using System;

namespace Steffensen_method
{
    static class Method
    {
        public static Solution Steffensen(Func<double, double> func, double x, double fault)
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
