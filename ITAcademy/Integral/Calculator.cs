using System;
using System.Collections.Generic;
using System.Text;

namespace Integral
{
    internal class Calculator
    {
        public double CalculateIntegral(Func<double, double> func)
        {
            var sInterval = 0d;
            // for (int i = 10; i < 2; i = i + 10)
            {
              sInterval = func(4);
            }
            return sInterval;
        }
    }
}
