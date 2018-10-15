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

            Solution result = Methods.NewtonMethodForNonlinearSystems(system, X0, Y0, Fault);

            Console.WriteLine($"X - {result.X}");
            Console.WriteLine($"Y - {result.Y}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
