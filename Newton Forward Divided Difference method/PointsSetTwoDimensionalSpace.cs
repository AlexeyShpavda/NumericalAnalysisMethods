using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Forward_Divided_Difference_method
{
    class PointsSetTwoDimensionalSpace
    {
        private ICollection<double> _x;
        private ICollection<double> _y;

        public PointsSetTwoDimensionalSpace(ICollection<double> x, ICollection<double> y)
        {
            X = x;
            Y = y;
        }

        public ICollection<double> X { get => _x; set => _x = value; }
        public ICollection<double> Y { get => _y; set => _y = value; }
    }
}
