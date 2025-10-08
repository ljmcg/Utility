namespace VarianceCollectorTests
{
    public class VarianceCollectorTests
    {
        [Fact]
        public void BaselineTest()
        {
            var varianceCalculator = new ljmcg.VarianceCalculator();
            for (int i = 0; i < 16; ++i)
            {
                varianceCalculator.Update(i);
            }
            Assert.Equal(16, varianceCalculator.Count);
            Assert.Equal(7.5, varianceCalculator.Mean, 7);
            Assert.Equal(21.25, varianceCalculator.Variance, 7);
            Assert.Equal(22.66666666, varianceCalculator.SampleVariance, 7);
        }
    }
}
