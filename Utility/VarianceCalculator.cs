namespace ljmcg
{
    //Welford's online algorithm variance
    public class VarianceCalculator
    {
        public void Update(double newValue)
        {
            Min = System.Math.Min(Min, newValue);
            Max = System.Math.Max(Max, newValue);
            ++Count;
            var delta = newValue - runningMean;
            runningMean += delta / Count;
            var delta2 = newValue - runningMean;
            runningM2 += delta * delta2;
        }
        public double Max { get; private set; } = double.MinValue;
        public double Min { get; private set; } = double.MaxValue;
        public long Count { get; private set; } = 0;
        public double Mean { get => runningMean; }
        public double Variance { get => runningM2/Count; }
        public double SampleVariance { get => runningM2 / (Count - 1); }
        private double runningMean { get; set; } = 0;
        private double runningM2 { get; set; } = 0;
    }
}
