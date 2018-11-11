using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lagrange_Interpolating_Polynomial
{
    static class Method
    {
        private static double BasicPolynomial(double x, double[] xArray, int i)
        {
            int size = xArray.Length;

            double basicPolynomial = 1;

            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    basicPolynomial *= (x - xArray[j]) / (xArray[i] - xArray[j]);
                }
            }

            return basicPolynomial;
        }

        public static double LagrangeInterpolatingPolynomial(double x, double[] xArray, double[] yArray)
        {
            int size = xArray.Length;

            double lagrangePolynomial = 0;

            for (int i = 0; i < size; i++)
            {
                lagrangePolynomial += BasicPolynomial(x, xArray, i) * yArray[i];
            }

            return lagrangePolynomial;
        }
    }
}
