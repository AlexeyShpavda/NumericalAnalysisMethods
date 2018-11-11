using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_method_for_Systems_of_Equations
{
    class System
    {
        public double f1(double x, double y)
        {
            return Math.Sin(x + y) - 1.2 * x - 0.2;
        }

        public double f2(double x, double y)
        {
            return x * x + y * y - 1;
        }

        public double df1dx(double x, double y)
        {
            return Math.Cos(x + y) - 1.2;
        }

        public double df1dy(double x, double y)
        {
            return Math.Cos(x + y);
        }

        public double df2dx(double x, double y)
        {
            return 2 * x;
        }

        public double df2dy(double x, double y)
        {
            return 2 * y;
        }
    }
}
