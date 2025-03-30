using System;
using Calculate;
using Xunit;

namespace ValidCalculate.Test
{
    public class ValidCalculate

    {
        [Fact]
        public void TestCalculateSumma()
        {
            double a = 1;
            double b = 3;

            CalculateClass calc = new CalculateClass();

            double res = calc.CalculateSumma(a, b);

            double true_value = 4;

            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateDifference()
        {
            double a = 1;
            double b = 3;

            CalculateClass calc = new CalculateClass();

            double res = calc.CalculateDifference(a, b);

            double true_value = -2;

            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateMultiplication()
        {
            double a = 2;
            double b = 3;

            CalculateClass calc = new CalculateClass();

            double res = calc.CalculateMultiplication(a, b);

            double true_value = 6;

            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateQuotient()
        {
            double a = 4;
            double b = 2;

            CalculateClass calc = new CalculateClass();

            double res = calc.CalculateQuotient(a, b);

            double true_value = 2;

            Assert.Equal(true_value, res);
        }
    }
}