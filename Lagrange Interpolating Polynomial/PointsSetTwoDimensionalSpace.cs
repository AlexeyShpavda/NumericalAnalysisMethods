﻿using System.Collections.Generic;

namespace Lagrange_Interpolating_Polynomial
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
