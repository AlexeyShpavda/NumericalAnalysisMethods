namespace Iterative_method_for_Systems_of_Equations
{
    class Solution
    {
        public Solution(double x, double y, uint iterationsNumber)
        {
            X = x;
            Y = y;
            IterationsNumber = iterationsNumber;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public uint IterationsNumber { get; set; }
    }
}
