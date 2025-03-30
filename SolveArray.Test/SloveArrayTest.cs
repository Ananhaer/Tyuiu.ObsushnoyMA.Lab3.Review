using System;
using Array;
using Xunit;

namespace ValidArray.Test
{
    public class ValidArray

    {
        [Fact]
        public void TestCalculateMinimum()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            int true_value = 1;

            ArrayClass arr_cl = new ArrayClass();

            int res = arr_cl.CalculateMinimum(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateMaximum()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            int true_value = 30;

            ArrayClass arr_cl = new ArrayClass();

            int res = arr_cl.CalculateMaximum(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateAverage()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 9.6;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.CalculateAverage(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateMedian()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 5;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.CalculateMedian(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateNumberOfEven()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 3;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.CalculateNumberOfEven(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestCalculateNumberOfOdd()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 2;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.CalculateNumberOfOdd(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestSignsOfDivisibilityByTwo()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 3;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.SignsOfDivisibilityByTwo(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestSignsOfDivisibilityByThree()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 1;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.SignsOfDivisibilityByThree(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestSignsOfDivisibilityByFive()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 3;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.SignsOfDivisibilityByFive(arr);
            Assert.Equal(true_value, res);
        }

        [Fact]
        public void TestSignsOfDivisibilityByTen()
        {
            int[] arr = new int[] { 1, 2, 5, 10, 30 };
            double true_value = 2;

            ArrayClass arr_cl = new ArrayClass();

            double res = arr_cl.SignsOfDivisibilityByTen(arr);
            Assert.Equal(true_value, res);
        }
    }
}