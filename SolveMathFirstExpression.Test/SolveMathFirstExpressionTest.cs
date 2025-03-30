using System;
using MathFirstExpression;
using Xunit;

namespace ValidMathFirstExpression.Test
{
    public class ValidMathFirstExpression
    {
        [Fact]
        public void TestCalculateFirstExpression()
        {
            double a = 0.5;
            double b = 0.2;
            double c = 0.1;

            MathFirstExpressionClass mfec = new MathFirstExpressionClass();

            double res = mfec.CalculateFirstExpression(a, b, c);

            double true_value = 25.311;

            Assert.Equal(true_value, res);
        }
    }
}
