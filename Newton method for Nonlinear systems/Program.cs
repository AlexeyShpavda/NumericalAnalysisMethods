using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_method_for_Nonlinear_systems
{
    class Program
    {
        static void Main()
        {
            const double Fault = 0.000000005;
            const double X0 = 0.8;
            const double Y0 = 0.8;

            System system = new System();

            Tuple<double, double, uint> result = Methods.NewtonMethodForNonlinearSystems(system, X0, Y0, Fault);

            Console.WriteLine($"X - {result.Item1}");
            Console.WriteLine($"Y - {result.Item2}");
            Console.WriteLine($"Number of Iterations -  {result.Item3}");

            Console.ReadKey();
        }
    }
}
