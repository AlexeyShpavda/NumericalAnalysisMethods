using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Squares_Method
{
    class PointSearch
    {
        public static PointsSetTwoDimensionalSpace LookForPointsUsingLinearFunction(
            Sum sum, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            double[] coefficients = Method.LinearFunction(sum, xArray, yArray);

            for (var i = 0; i < xArray.Length; i++)
            {
                x.Add(xArray[i]);
                y.Add(coefficients[0] * xArray[i] + coefficients[1]);
            }

            return new PointsSetTwoDimensionalSpace(x, y);
        }

        public static PointsSetTwoDimensionalSpace LookForPointsUsingQuadraticFunction(
            Sum sum, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            double[] coefficients = Method.QuadraticFunction(sum, xArray, yArray);

            for (var i = 0; i < xArray.Length; i++)
            {
                x.Add(xArray[i]);
                y.Add(coefficients[0] * (xArray[i] * xArray[i]) + coefficients[1] * xArray[i] + coefficients[2]);
            }
            return new PointsSetTwoDimensionalSpace(x, y);
        }

        public static PointsSetTwoDimensionalSpace LookForPointsUsingExponentialFunction(
            Sum sum, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            double[] coefficients = Method.ExponentialFunction(sum, xArray, yArray);

            for (var i = 0; i < xArray.Length; i++)
            {
                x.Add(xArray[i]);
                y.Add(coefficients[0] * Math.Exp(coefficients[1] * xArray[i]));
            }
            return new PointsSetTwoDimensionalSpace(x, y);
        }

        public static PointsSetTwoDimensionalSpace LookForPointsUsingLogarithmicFunction(
            Sum sum, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            double[] coefficients = Method.LogarithmicFunction(sum, xArray, yArray);

            for (var i = 0; i < xArray.Length; i++)
            {
                x.Add(xArray[i]);
                y.Add(coefficients[0] * Math.Log(xArray[i]) + coefficients[1]);
            }
            return new PointsSetTwoDimensionalSpace(x, y);
        }

        public static PointsSetTwoDimensionalSpace LookForPointsUsingHyperbolicFunction(
            Sum sum, double[] xArray, double[] yArray)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();

            double[] coefficients = Method.HyperbolicFunction(sum, xArray, yArray);
            for (var i = 0; i < xArray.Length; i++)
            {
                x.Add(xArray[i]);
                y.Add(coefficients[0] / xArray[i] + coefficients[1]);
            }
            return new PointsSetTwoDimensionalSpace(x, y);
        }
    }
}
