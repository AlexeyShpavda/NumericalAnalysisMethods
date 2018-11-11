using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Least_Squares_Method
{
    class Sum
    {
        public double SumXFirstDegree(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += elem;
            }
            return sum;
        }

        public double SumXSquares(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += elem * elem;
            }
            return sum;
        }

        public double SumXCubes(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += elem * elem * elem;
            }
            return sum;
        }

        public double SumXFourthDegree(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += elem * elem * elem * elem;
            }
            return sum;
        }

        public double SumXMultY(double[] xArray, double[] yArray)
        {
            double sum = 0;
            for (var i = 0; i < xArray.Length; i++)
            {
                sum += xArray[i] * yArray[i];
            }
            return sum;
        }

        public double SumSquareXMultY(double[] xArray, double[] yArray)
        {
            double sum = 0;
            for (var i = 0; i < xArray.Length; i++)
            {
                sum += xArray[i] * xArray[i] * yArray[i];
            }
            return sum;
        }

        public double SumLogX(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += Math.Log(elem);
            }
            return sum;
        }

        public double SumLogXMultLogX(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += Math.Log(elem) * Math.Log(elem);
            }
            return sum;
        }

        public double SumYMultLogX(double[] xArray, double[] yArray)
        {
            double sum = 0;
            for (var i = 0; i < xArray.Length; i++)
            {
                sum += (yArray[i] * Math.Log(xArray[i]));
            }
            return sum;
        }

        public double Sum1DevX(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += 1.0 / elem;
            }
            return sum;
        }

        public double Sum1DevXSquare(double[] xArray)
        {
            double sum = 0;
            foreach (var elem in xArray)
            {
                sum += 1.0 / (elem * elem);
            }
            return sum;
        }

        public double SumYDevX(double[] xArray, double[] yArray)
        {
            double sum = 0;
            for (var i = 0; i < xArray.Length; i++)
            {
                sum += yArray[i] / xArray[i];
            }
            return sum;
        }
    }
}