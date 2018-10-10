using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Forward_Divided_Difference_method
{
    static class PointSearch
    {
        public static Tuple<List<double>, List<double>> LookForPointsUsingForwardNewtonFormula(
            float leftBorder, float rightBorder, float step, double[] xArray, double[] yArray)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();

            for (var i = leftBorder; i <= rightBorder; i += step)
            {
                xs.Add(i);
                ys.Add(Methods.NewtonForwardMethod(i, xArray.Length, xArray, yArray, step));
            }

            return new Tuple<List<double>, List<double>>(xs, ys);
        }
    }
}
