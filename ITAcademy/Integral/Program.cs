using System;
using System.Linq.Expressions;

namespace Integral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите функцию для вычисления с параметром x");

            var str = Console.ReadLine();
            try
            {
                var x = Expression.Parameter(typeof(double), "x");
                var expression = ParseFormula.DynamicExpression.ParseLambda(new ParameterExpression[] {x}, typeof(double), str);

                var func = (Func<double, double>)expression.Compile();

                var calc = new Calculator();

                var y = calc.CalculateIntegral(func);

                Console.Write($"result f(2) = {y}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
