using System;

namespace Newton_method_for_Nonlinear_systems
{
    class Program
    {
        static void Main()
        {
            const double Fault = 0.00001;
            const double X0 = 0.5;
            const double Y0 = 1.0;

            System system = new System();

            Solution result = Method.NewtonMethodForNonlinearSystems(system, X0, Y0, Fault);

            Console.WriteLine($"X - {result.X}");
            Console.WriteLine($"Y - {result.Y}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
