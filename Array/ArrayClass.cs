using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayClass
    {
        public int CalculateMinimum(int[] arr)
        {
            return arr.Min();
        }

        public int CalculateMaximum(int[] arr)
        {
            return arr.Max();
        }

        public double CalculateAverage(int[] arr)
        {
            return arr.Average();
        }

        public double CalculateMedian(int[] arr)
        {
            int[] sortedarr = arr.OrderBy(n => n).ToArray();
            int length = sortedarr.Length;

            if (length % 2 == 1)
            {
                return sortedarr[length / 2];
            }
            else
            {
                return (sortedarr[length / 2 - 1] + sortedarr[length / 2]) / 2.0;
            }
        }

        public int CalculateNumberOfEven(int[] arr)
        {
            return arr.Count(n => n % 2 == 0);
        }

        public int CalculateNumberOfOdd(int[] arr)
        {
            return arr.Count(n => n % 2 != 0);
        }

        public int SignsOfDivisibilityByTwo(int[] arr)
        {
            return arr.Count(n => n % 2 == 0);
        }

        public int SignsOfDivisibilityByThree(int[] arr)
        {
            return arr.Count(n => n % 3 == 0);
        }

        public int SignsOfDivisibilityByFive(int[] arr)
        {
            return arr.Count(n => n % 5 == 0);
        }

        public int SignsOfDivisibilityByTen(int[] arr)
        {
            return arr.Count(n => n % 10 == 0);
        }
    }
}
