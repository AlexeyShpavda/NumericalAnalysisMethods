using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chord_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Atan(1 / x) - x * x;
        }

        public static double dF(double x)
        {
            return -2 * x - (1 / ((x * x) * (1 + 1 / (x * x))));
        }

        public static double ddF(double x)
        {
            return 2 * (-1 + 1 / ((x * x * x) * (1 + 1 / (x * x))) - (1 / ((x * x * x * x * x) * (1 + (1 / (x * x)) * (1 / (x * x))))));
        }

        static void Main()
        {
            const double Fault = 0.00005;
            const double LeftBorder = 0;
            const double RightBorder = 1;

            Methods.Function func = F;
            Methods.Function secondFunctionDerivative = ddF;

            Tuple<double, double> Result = Methods.ChordMethod(func, secondFunctionDerivative, LeftBorder, RightBorder, Fault);

            Console.WriteLine($"Solution - {Result.Item1}");
            Console.WriteLine($"Number of Iterations -  {Result.Item2}");

            Console.ReadKey();
        }
    }
}
