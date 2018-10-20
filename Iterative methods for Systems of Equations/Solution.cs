using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterative_method_for_Systems_of_Equations
{
    class Solution
    {
        private double _x;
        private double _y;
        private uint _iterationsNumber;

        public Solution(double x, double y, uint iterationsNumber)
        {
            X = x;
            Y = y;
            IterationsNumber = iterationsNumber;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public uint IterationsNumber { get => _iterationsNumber; set => _iterationsNumber = value; }
    }
}
