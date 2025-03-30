using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSecondExpression
{
    public class MathSecondExpressionClass
    {
        public double CalculateSecondExpression(double a, double b)
        {
            double c_1 = (b * b) - Math.Cos(a * a) + 10;
            double c_2 = (a * a) - Math.Sin(b * b) + 12;

            if (c_2 == 0) { return 0; }

            return c_1 / c_2;
        }
    }
}
