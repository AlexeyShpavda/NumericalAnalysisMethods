using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_methods_for_Systems_of_Equations
{
    class Program
    {
        static void Main()
        {
            const double X0 = 0.5;
            const double Y0 = 0.5;
            const double Fault = 0.000000005;

            System system = new System();

            Tuple<double, double, uint> result = Methods.IterativeMethodsForSystemsOfEquations(system, X0, Y0, Fault);

            Console.WriteLine($"X - {result.Item1}");
            Console.WriteLine($"Y - {result.Item2}");
            Console.WriteLine($"Number of Iterations -  {result.Item3}");

            Console.ReadKey();
        }
    }
}
