using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Forward_Divided_Difference_method
{
    static class Method
    {
        static private double[,] FillingTable(double[] xArray, double[] yArray, int numberOfLines)
        {
            double[,] table = new double[numberOfLines + 1, numberOfLines];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < numberOfLines; j++)
                {
                    if (i == 0)
                    {
                        table[i, j] = xArray[j];
                    }
                    else
                    {
                        table[i, j] = yArray[j];
                    }
                }
            }

            for (int i = 2, n = numberOfLines - 1; i < numberOfLines; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = table[i - 1, j + 1] - table[i - 1, j];
                }
                n--;
            }

            return table;
        }

        static public double NewtonForwardMethod(double x, int numberOfLines, double[] xArray, double[] yArray, double step)
        {
            double[,] table = FillingTable(xArray, yArray, numberOfLines);

            double[] dY = new double[numberOfLines];

            for (int i = 1; i < numberOfLines; i++)
            {
                dY[i] = table[i, 0];
            }

            double[] xN = new double[numberOfLines - 1];
            xN[0] = x - table[0, 0];
            for (int i = 1; i < numberOfLines - 1; i++)
            {
                xN[i] = xN[i - 1] * (x - table[0, i]);
            }

            double result = dY[0];
            for (int i = 1, fact = 1; i < numberOfLines; i++)
            {
                fact = fact * i;
                result = result + (dY[i] * xN[i - 1]) / (fact * Math.Pow(step, i));
            }

            return result;
        }
    }
}