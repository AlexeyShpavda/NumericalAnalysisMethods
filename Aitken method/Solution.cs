using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aitken_method
{
    class Solution
    {
        private double _approximateRoot;
        private uint _iterationsNumber;

        public Solution(double approximateRoot, uint iterationsNumber)
        {
            ApproximateRoot = approximateRoot;
            IterationsNumber = iterationsNumber;
        }

        public double ApproximateRoot { get => _approximateRoot; set => _approximateRoot = value; }
        public uint IterationsNumber { get => _iterationsNumber; set => _iterationsNumber = value; }
    }
}
