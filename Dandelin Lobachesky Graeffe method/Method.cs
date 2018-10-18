using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dandelin_Lobachesky_Graeffe_method
{
    static class Method
    {
        public delegate double Function(double x);

        public static List<double> DandelinLobacheskyGraeffeMethod(Function func, double[] polynomialCoefficients, double fault)
        {
            ushort iteration = 1;

            while(true)
            {
                double A0 = Math.Pow(polynomialCoefficients[0], 2);
                double A1 = Math.Pow(polynomialCoefficients[1], 2) - 2 * polynomialCoefficients[0] * polynomialCoefficients[2];
                double A2 = Math.Pow(polynomialCoefficients[2], 2) - 2 * polynomialCoefficients[1] * polynomialCoefficients[3];
                double A3 = Math.Pow(polynomialCoefficients[3], 2);

                double x1 = Math.Pow((A1 / A0), (1.0 / Math.Pow(2, iteration)));
                double x2 = Math.Pow((A2 / A1), (1.0 / Math.Pow(2, iteration)));
                double x3 = Math.Pow((A3 / A2), (1.0 / Math.Pow(2, iteration)));

                iteration++;

                if ((func(-x1) < fault || func(x1) < fault) &&
                    (func(-x2) < fault || func(x2) < fault) &&
                    (func(-x3) < fault || func(x3) < fault))
                {
                    return new List<double> {
                        func(-x1) < fault ? -x1 : x1,
                        func(-x2) < fault ? -x2 : x2,
                        func(-x3) < fault ? -x3 : x3
                    };
                }

                polynomialCoefficients[0] = A0;
                polynomialCoefficients[1] = A1;
                polynomialCoefficients[2] = A2;
                polynomialCoefficients[3] = A3;
            }
        }
    }
}
