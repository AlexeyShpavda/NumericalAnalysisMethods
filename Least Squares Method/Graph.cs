using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Least_Squares_Method
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            double[] xArray = new double[] { 1.00, 1.64, 2.28, 2.91, 3.56, 4.19, 4.84, 5.48 };
            double[] yArray = new double[] { 0.28, 0.19, 0.15, 0.11, 0.09, 0.08, 0.07, 0.06 };

            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            chart.Series.Add("Linear Function:\n y = ax + b");
            chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series.Add("Second Degree Polynomial:\n y = a*x^2 + b*x + c");
            chart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series.Add("Exponential Function:\n y = a*exp(b*e)");
            chart.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series.Add("Logarithmic Function:\n y = a*ln(x) + b");
            chart.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            chart.Series.Add("Hyperbolic Function:\n y = a/x + b");
            chart.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            Sum sum = new Sum();
            PointsSetTwoDimensionalSpace pointsSet;
            chart.Series[0].Points.DataBindXY(xArray, yArray);

            pointsSet = PointSearch.LookForPointsUsingLinearFunction(sum, xArray, yArray);
            chart.Series[1].Points.DataBindXY(pointsSet.X, pointsSet.Y);

            pointsSet = PointSearch.LookForPointsUsingQuadraticFunction(sum, xArray, yArray);
            chart.Series[2].Points.DataBindXY(pointsSet.X, pointsSet.Y);

            pointsSet = PointSearch.LookForPointsUsingExponentialFunction(sum, xArray, yArray);
            chart.Series[3].Points.DataBindXY(pointsSet.X, pointsSet.Y);

            pointsSet = PointSearch.LookForPointsUsingLogarithmicFunction(sum, xArray, yArray);
            chart.Series[4].Points.DataBindXY(pointsSet.X, pointsSet.Y);

            pointsSet = PointSearch.LookForPointsUsingHyperbolicFunction(sum, xArray, yArray);
            chart.Series[5].Points.DataBindXY(pointsSet.X, pointsSet.Y);
        }
    }
}
