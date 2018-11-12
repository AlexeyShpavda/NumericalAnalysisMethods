namespace Aitken_method
{
    class Solution
    {
        public Solution(double approximateRoot, uint iterationsNumber)
        {
            ApproximateRoot = approximateRoot;
            IterationsNumber = iterationsNumber;
        }

        public double ApproximateRoot { get; set; }

        public uint IterationsNumber { get; set; }
    }
}
