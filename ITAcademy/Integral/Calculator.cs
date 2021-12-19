using System;

namespace Integral
{
    public static class Calculator
    {
        public static double CalculateIntegral(Func<double, double> func, int n)
        {
            double a = -10;
            double b = 10;
            double h = (b - a) / n;
            double sum = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                sum += h * func(a + i * h);
            }
            return sum;
        }


    }
}
