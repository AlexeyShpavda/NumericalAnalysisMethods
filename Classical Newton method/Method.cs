﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classical_Newton_method
{
    class Method
    {
        public delegate double Function(double x);

        public static Solution ClassicalNewton(Function func, Function funcDerivative, double x, double fault)
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
