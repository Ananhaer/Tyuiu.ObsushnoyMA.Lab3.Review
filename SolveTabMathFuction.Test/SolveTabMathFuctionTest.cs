using System;
using TabMathFuction;
using Xunit;

namespace ValidTabMathFuction.Test
{
    public class ValidTabMathFuction

    {
        [Fact]
        public void TestCalculateTabMathFuction()
        {
            string[] expected = { "0.30", "0.47", "0.63" };

            TabMathFuctionClass tabulator = new TabMathFuctionClass();
            string[] actual = tabulator.CalculateTabMathFuction(1, 3);

            Assert.Equal(expected, actual);
        }
    }
}