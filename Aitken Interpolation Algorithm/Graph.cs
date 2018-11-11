using System.Windows.Forms;

namespace Aitken_Interpolation_Algorithm
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            double[] xArray = new double[] { 0.43, 0.48, 0.55, 0.62, 0.70, 0.75 };
            double[] yArray = new double[] { 1.63597, 1.73234, 1.87686, 2.03045, 2.22846, 2.35973 };
            const double Argument = 0.608;

            AitkenInterpolation.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            AitkenInterpolation.Series.Add("Interpolation Nodes");
            AitkenInterpolation.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            AitkenInterpolation.Series[0].Points.AddXY(Argument, Method.AitkenInterpolation( Argument, xArray, yArray));
			AitkenInterpolation.Series[1].Points.DataBindXY(xArray, yArray);	
        }
    }
}