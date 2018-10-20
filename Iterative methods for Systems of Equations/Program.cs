using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_method_for_Systems_of_Equations
{
    class Program
    {
        static void Main()
        {
            const double X0 = 0.0;
            const double Y0 = 1.5;
            const double Fault = 0.00001;

            System system = new System();

            Solution result = Method.IterativeMethodForSystemsOfEquations(system, X0, Y0, Fault);

            Console.WriteLine($"X - {result.X}");
            Console.WriteLine($"Y - {result.Y}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
