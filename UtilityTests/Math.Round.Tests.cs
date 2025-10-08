using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTests
{
    public class Math_Round_Tests
    {
        [Theory]
        [InlineData(2,16,16)]
        [InlineData(0,16,0)]
        [InlineData(1,5,5)]
        [InlineData(10, 5, 10)]
        public void RoundUpToMultipleIntTestSuccess(int original, int factor, int expected)
        {
            Assert.Equal(expected, ljmcg.Math.RoundUpToMultiple(original,factor));
        }
        [Theory]
        [InlineData(2, 16, 16)]
        [InlineData(0, 16, 0)]
        [InlineData(1, 5, 5)]
        [InlineData(10, 5, 10)]
        public void RoundUpToMultipleLongTestSuccess(long original, long factor, long expected)
        {
            Assert.Equal(expected, ljmcg.Math.RoundUpToMultiple(original, factor));
        }
        [Theory]
        [InlineData(-1, 16)]
        [InlineData(0, 0)]
        [InlineData(-10, -10)]
        public void RoundUpToMultipleIntTestThrow(int original, int factor)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>ljmcg.Math.RoundUpToMultiple(original, factor));
        }
        [Theory]
        [InlineData(-1, 16)]
        [InlineData(0, 0)]
        [InlineData(-10, -10)]
        public void RoundUpToMultiplLongTestThrow(long original, long factor)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ljmcg.Math.RoundUpToMultiple(original, factor));
        }
    }
}
