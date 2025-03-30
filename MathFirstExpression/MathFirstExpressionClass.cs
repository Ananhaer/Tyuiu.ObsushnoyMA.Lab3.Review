using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFirstExpression
{
    public class MathFirstExpressionClass
    {
        public double CalculateFirstExpression(double a, double b, double c)
        {
            if (a==0)
            {
                return 0;
            }
            double z = (b + Math.Sqrt(4 * a * c)) / 2 - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            double z_round = Math.Round(z, 3);
            return z_round;
        }
    }
}
