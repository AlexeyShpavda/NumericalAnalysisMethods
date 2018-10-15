using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_method_for_Nonlinear_systems
{
    static class Methods
    {
        static public Solution NewtonMethodForNonlinearSystems(System system, double x, double y, double fault)
        {
            uint iterationsNumber = 0;

            while ((Math.Abs(system.f1(x, y)) > fault) && (Math.Abs(system.f2(x, y)) > fault)) 
            {
                x = x - (system.f1(x, y) * system.df2dy(x, y) - system.df1dy(x, y) * system.f2(x, y)) /
                          (system.df1dx(x, y) * system.df2dy(x, y) - system.df2dx(x, y) * system.df1dy(x, y));

                y = y - (system.df1dx(x, y) * system.f2(x, y) - system.f1(x, y) * system.df2dx(x, y)) /
                          (system.df1dx(x, y) * system.df2dy(x, y) - system.df2dx(x, y) * system.df1dy(x, y));

                iterationsNumber++;
            }

            return new Solution(x, y, iterationsNumber);
        }
    }
}
