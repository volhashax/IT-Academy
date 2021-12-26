using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = ArrayGeneration(n-1);
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(IsPrimeNumber(array[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static int[] ArrayGeneration(int n)
        {
            int[] array = new int[n];

            for (int i = 1; i <= array.Length; i++)
            {
                array[i - 1] = i;
            }

            return array;
        }

        private static bool IsPrimeNumber(int n)
        {
           for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return n == 1 ? false : true;
        }
    }
}
