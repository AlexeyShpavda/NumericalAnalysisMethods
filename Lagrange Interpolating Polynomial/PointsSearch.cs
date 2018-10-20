using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagrange_Interpolating_Polynomial
{
    static class PointsSearch
    {
        public static PointsSetTwoDimensionalSpace LookForPointsUsingLagrangeInterpolationFormula(
            float leftBorder, float rightBorder, float step, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            for (var i = leftBorder; i <= rightBorder; i += step)
            {
                x.Add(i);
                y.Add(Method.LagrangeInterpolatingPolynomial(i, xArray, yArray));
            }

            return new PointsSetTwoDimensionalSpace(x, y);
        }
    }
}
