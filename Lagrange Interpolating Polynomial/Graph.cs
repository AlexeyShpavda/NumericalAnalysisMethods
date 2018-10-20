using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagrange_Interpolating_Polynomial
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            double[] xArray = new double[] { 0.43, 0.48, 0.55, 0.62, 0.70, 0.75 };
            double[] yArray = new double[] { 1.63597, 1.73234, 1.87686, 2.03045, 2.22846, 2.35973 };

            const float LeftBorder = 0.0f;
            const float RightBorder = 1.0f;
            const float Step = 0.001f;

            LagrangePolynomial.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            PointsSetTwoDimensionalSpace pointsSet = PointsSearch.LookForPointsUsingLagrangeInterpolationFormula(
                LeftBorder, RightBorder, Step, xArray, yArray);

            LagrangePolynomial.Series[0].Points.DataBindXY(pointsSet.X, pointsSet.Y);
        }
    }
}
