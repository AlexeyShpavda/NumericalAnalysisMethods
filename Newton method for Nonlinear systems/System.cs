using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_method_for_Nonlinear_systems
{
    class System
    {
        public double f1(double x, double y)
        {
            return Math.Cos(x) + y - 1.5;
        }

        public double f2(double x, double y)
        {
            return 2 * x - Math.Sin(y - 0.5) - 1;
        }

        public double df1dx(double x, double y)
        {
            return -Math.Sin(x);
        }

        public double df1dy(double x, double y)
        {
            return 1;
        }

        public double df2dx(double x, double y)
        {
            return 2;
        }

        public double df2dy(double x, double y)
        {
            return -Math.Cos(y - 0.5);
        }
    }
}
