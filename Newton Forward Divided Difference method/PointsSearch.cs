using System.Collections.Generic;

namespace Newton_Forward_Divided_Difference_method
{
    static class PointsSearch
    {
        public static PointsSetTwoDimensionalSpace LookForPointsUsingForwardNewtonFormula(
            float leftBorder, float rightBorder, float step, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            for (var i = leftBorder; i <= rightBorder; i += step)
            {
                x.Add(i);
                y.Add(Method.NewtonForwardMethod(i, xArray.Length, xArray, yArray, step));
            }

            return new PointsSetTwoDimensionalSpace(x, y);
        }
    }
}
