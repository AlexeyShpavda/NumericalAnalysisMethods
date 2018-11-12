namespace Newton_method_for_Nonlinear_systems
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
