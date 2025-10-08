using ljmcg;

namespace MathTests
{
    public class Math_Prime_Tests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(29)]
        [InlineData(31)]
        [InlineData(1000009867)]
        public void IsPrimeIntTestsTrue(int value)
        {
            Assert.True(ljmcg.Math.IsPrime(value));
        }
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(29)]
        [InlineData(31)]
        [InlineData(1000009867)]
        public void IsPrimeLongTestsTrue(long value)
        {
            Assert.True(ljmcg.Math.IsPrime(value));
        }
        [Theory]
        [InlineData(-8)]
        [InlineData(-7)]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(4)]        
        [InlineData(12)]
        [InlineData(87)]
        [InlineData(100)]
        [InlineData(1000009869)]
        public void IsPrimeIntTestsFalse(int value)
        {
            Assert.False(ljmcg.Math.IsPrime(value));
        }
        [Theory]
        [InlineData(-8)]
        [InlineData(-7)]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(12)]
        [InlineData(87)]
        [InlineData(100)]
        [InlineData(1000009869)]
        public void IsPrimeLongTestsFalse(long value)
        {
            Assert.False(ljmcg.Math.IsPrime(value));
        }
        [Theory]
        [InlineData(6, 5)]
        [InlineData(7, 5)]
        [InlineData(13, 11)]
        [InlineData(17, 13)]
        [InlineData(14, 13)]
        public void GreatestPrimeLessThanIntTestSuccess(int value, int expected)
        {
            var result = ljmcg.Math.GreatestPrimeLessThan(value);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(6, 5)]
        [InlineData(7, 5)]
        [InlineData(13, 11)]
        [InlineData(17, 13)]
        [InlineData(14, 13)]
        public void GreatestPrimeLessThanLongTestSuccess(long value, long expected)
        {
            var result = ljmcg.Math.GreatestPrimeLessThan(value);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(4, 5)]
        [InlineData(5, 7)]
        [InlineData(11, 13)]
        [InlineData(13, 17)]
        [InlineData(16, 17)]
        [InlineData(31, 37)]
        public void LeastPrimeGreaterThanIntTestSuccess(int value, int expected)
        {
            var result = ljmcg.Math.LeastPrimeGreaterThan(value);
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(4, 5)]
        [InlineData(5, 7)]        
        [InlineData(11, 13)]
        [InlineData(13, 17)]
        [InlineData(16, 17)]
        [InlineData(31, 37)]
        public void LeastPrimeGreaterThanLongTestSuccess(long value, long expected)
        {
            var result = ljmcg.Math.LeastPrimeGreaterThan(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3)]
        public void GreatestPrimeLessThanIntTestThrows(int original)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ljmcg.Math.GreatestPrimeLessThan(original));
        }
        [Theory]
        [InlineData(3)]
        public void GreatestPrimeLessThanLongTestThrows(long original)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ljmcg.Math.GreatestPrimeLessThan(original));
        }
    }
}
