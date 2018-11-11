using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_method_for_Systems_of_Equations
{
    static class Method
    {
        static private double UsedFunction(System system, double x, double y, double[] c)
        {
            return c[0] * system.f1(x, y) + c[1] * system.f2(x, y);
        }

        static public Solution IterativeMethodForSystemsOfEquations(System system, double x, double y, double fault)
        {
            uint iterationsNumber = 0;

            double[,] a = { { system.df1dx(x, y), system.df2dx(x, y) }, { system.df2dx(x, y), system.df2dy(x, y) } };

            double[] solve_for_x = { -1, 0 };
            alglib.rmatrixsolve(a, 2, solve_for_x, out int t1, out alglib.densesolverreport s1, out double[] c1);

            double[] solve_for_y = { 0, -1 };
            alglib.rmatrixsolve(a, 2, solve_for_y, out int t2, out alglib.densesolverreport s2, out double[] c2);

            while ((Math.Abs(system.f1(x, y)) > fault) && (Math.Abs(system.f2(x, y)) > fault))
            {
                x = x + UsedFunction(system, x, y, c1);
                y = y + UsedFunction(system, x, y, c2);

                iterationsNumber++;
            }

            return new Solution(x, y, iterationsNumber);
        }
    }
}
