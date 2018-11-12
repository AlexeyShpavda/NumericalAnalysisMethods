using System.Collections.Generic;

namespace Lagrange_Interpolating_Polynomial
{
    class PointsSetTwoDimensionalSpace
    {
        public PointsSetTwoDimensionalSpace(ICollection<double> x, ICollection<double> y)
        {
            X = x;
            Y = y;
        }

        public ICollection<double> X { get; set; }

        public ICollection<double> Y { get; set; }
    }
}
