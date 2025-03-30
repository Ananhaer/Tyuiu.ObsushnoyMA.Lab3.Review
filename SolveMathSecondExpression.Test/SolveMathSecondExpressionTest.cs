using System;
using MathSecondExpression;
using Xunit;

namespace ValidMathSecondExpression.Test
{
    public class ValidMathSecondExpression

    {
        [Fact]
        public void TestCalculateSecondExpression()
        {
            double a = 0.5;
            double b = 0.2;

            MathSecondExpressionClass msec = new MathSecondExpressionClass();

            double res = msec.CalculateSecondExpression(a, b);

            double true_value = 0.738;

            Assert.Equal(true_value, res);
        }
    }
}