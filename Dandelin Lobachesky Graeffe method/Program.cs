using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandelin_Lobachesky_Graeffe_method
{
    class Program
    {
        static double F(double x)
        {
            return x * x * x - 12 * x + 6;
        }

        static void Main()
        {
            double[] polynomialCoefficients = {1, 0, -12, 6 };
            const double Fault = 0.00005;

            Func<double, double> func = F;

            ICollection<double> result = Method.DandelinLobacheskyGraeffeMethod(func, polynomialCoefficients, Fault);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
