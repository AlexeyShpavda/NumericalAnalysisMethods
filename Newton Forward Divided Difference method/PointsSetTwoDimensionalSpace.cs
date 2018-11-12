using System.Collections.Generic;

namespace Newton_Forward_Divided_Difference_method
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
