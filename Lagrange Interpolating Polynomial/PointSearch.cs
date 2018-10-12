using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagrange_Interpolating_Polynomial
{
    static class PointSearch
    {
        public static Tuple<List<double>, List<double>> LookForPointsUsingLagrangeInterpolationFormula(
            float leftBorder, float rightBorder, float step, double[] xArray, double[] yArray)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            for (var i = leftBorder; i <= rightBorder; i += step)
            {
                xs.Add(i);
                ys.Add(Methods.LagrangeInterpolatingPolynomial(i, xArray, yArray));
            }

            return new Tuple<List<double>, List<double>>(xs, ys);
        }
    }
}
