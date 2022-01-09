using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sorting type (1 - Buble; 2 - Quick): ");
            var choice = Console.ReadLine();

            var array = GenerateArray();

            OutputArray("Initial", array);

            switch (choice)
            {
                case "1":
                    Bubble.SortWithBubble(array);
                    break;

                case "2":
                    Quick.SortWithQuick(array, 0, array.Length-1);
                    break;

                default:
                    break;
            }

            OutputArray("Sorted", array);
        }

        private static double[] GenerateArray()
        {
            var rnd = new Random();
            var array = new double[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 100;
            }

            return array;
        }
        
        private static void OutputArray(string message, double[] array)
        {
            Console.Write($"{message} array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
