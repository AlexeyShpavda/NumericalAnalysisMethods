using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Squares_Method
{
    static class Method
    {
        public static double[] LinearFunction(Sum sum, double[] xArray, double[] yArray)
        {
            double[] coefficients = new double[2];

            double[,] matrix = {{sum.SumXSquares(xArray), sum.SumXFirstDegree(xArray) },
                                    {sum.SumXFirstDegree(xArray), xArray.Length } };
            double[] solution = { sum.SumXMultY(xArray, yArray), sum.SumXFirstDegree(yArray) };

            alglib.rmatrixsolve(matrix, 2, solution, out int t, out alglib.densesolverreport c, out coefficients);
            return coefficients;
        }

        public static double[] QuadraticFunction(Sum sum, double[] xArray, double[] yArray)
        {
            double[] coefficients = new double[3];

            double[,] matrix = {{sum.SumXFourthDegree(xArray), sum.SumXCubes(xArray),sum.SumXSquares(xArray) },
                                    {sum.SumXCubes(xArray),sum.SumXSquares(xArray), sum.SumXFirstDegree(xArray) },
                                    {sum.SumXSquares(xArray),sum.SumXFirstDegree(xArray),xArray.Length } };
            double[] solution = { sum.SumSquareXMultY(xArray, yArray), sum.SumXMultY(xArray, yArray), sum.SumXFirstDegree(yArray) };

            alglib.rmatrixsolve(matrix, 3, solution, out int t, out alglib.densesolverreport c, out coefficients);
            return coefficients;
        }

        public static double[] ExponentialFunction(Sum sum, double[] xArray, double[] yArray)
        {
            double[] coefficients = new double[2];

            double[,] matrix = {{sum.SumXSquares(xArray), sum.SumXFirstDegree(xArray)},
                                    {sum.SumXFirstDegree(xArray),xArray.Length }};
            double[] solution = { sum.SumYMultLogX(xArray, yArray), sum.SumLogX(yArray) };

            alglib.rmatrixsolve(matrix, 2, solution, out int t, out alglib.densesolverreport c, out coefficients);
            return coefficients;
        }

        public static double[] LogarithmicFunction(Sum sum, double[] xArray, double[] yArray)
        {
            double[] coefficients = new double[2];

            double[,] matrix = {{sum.SumLogXMultLogX(xArray), sum.SumLogX(xArray) },
                                    {sum.SumLogX(xArray), xArray.Length } };
            double[] solution = { sum.SumYMultLogX(xArray, yArray), sum.SumXFirstDegree(yArray) };

            alglib.rmatrixsolve(matrix, 2, solution, out int t, out alglib.densesolverreport c, out coefficients);
            return coefficients;
        }

        public static double[] HyperbolicFunction(Sum sum, double[] xArray, double[] yArray)
        {
            double[] coefficients = new double[2];

            double[,] matrix = {{sum.Sum1DevXSquare(xArray), sum.Sum1DevX(xArray)},
                                    {sum.Sum1DevX(xArray),xArray.Length }};
            double[] solution = { sum.SumYDevX(xArray, yArray), sum.SumXFirstDegree(yArray) };

            alglib.rmatrixsolve(matrix, 2, solution, out int t, out alglib.densesolverreport c, out coefficients);
            return coefficients;
        }
    }
}