using System;
using System.Diagnostics;
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

                Stopwatch stopWatch = new Stopwatch();

                //кол-во разбиений
                int k = 2;
                //разница значений интегралов с разным разбиением
                double diff = 1;

                double[] p = { 0.01, 0.05, 0.1 };

                for (int j = 0; j < p.Length; j++)
                {
                    stopWatch.Start();

                    int i = 0;
                    do
                    {
                         i++;
                        
                        var sum1 = Calculator.CalculateIntegral(func, k * i);

                        
                        var sum2 = Calculator.CalculateIntegral(func, k * (i + 1));
                        

                        diff = Math.Abs(sum1 - sum2);
                    } while (diff > p[j]);

                    stopWatch.Stop();

                    TimeSpan ts = stopWatch.Elapsed;

                    string elapsedTime = String.Format("{0:00}.{1:00} секунд", ts.Seconds, ts.Milliseconds / 10);

                    var result = Calculator.CalculateIntegral(func, k * (i + 1));
                    Console.WriteLine($"Значение интеграла: {result}");
                    Console.WriteLine($"Время вычисления: {elapsedTime}");
                    Console.WriteLine($"Кол-во итераций: {k * (i + 1)}");
                    Console.WriteLine($"Точность: {p[j]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
