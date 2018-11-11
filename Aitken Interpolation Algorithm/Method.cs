using System.Collections.Generic;

namespace Aitken_Interpolation_Algorithm
{
    static class Method
    {
        private static void CreateTable(ref List<List<double>> table, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                table.Add(new List<double>());
            }
        }

        private static void FillInTable(ref List<List<double>> table, int size, double argument, double[] xArray, double[] yArray)
        {
            table[0].AddRange(yArray);

            for (int step = 1; step <= size; step++)
            {
                for (int i = 1; i < table[step - 1].Count; i++)
                {
                    double polynomial = 1 / (xArray[i + step - 1] - xArray[i - 1]) *
                        ((table[step - 1][i - 1] * (xArray[i + step - 1] - argument)) -
                        ((xArray[i - 1] - argument) * table[step - 1][i]));

                    table[step].Add(polynomial);
                }
            }
        }

        public static double AitkenInterpolation(double argument, double[] xArray, double[] yArray)
        {
            int size = yArray.Length;

            List<List<double>> table = new List<List<double>>();

            CreateTable(ref table, size);

            FillInTable(ref table, size, argument, xArray, yArray);

            return table[size - 1][0];
        }
    }
}
