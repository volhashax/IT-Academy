namespace Sorting
{
    public static class Bubble
    {
        public static void SortWithBubble(double[] array)
        {
            for (int j = 1; j <= array.Length - 1; j++)
            {
                for (int i = 0; i <= array.Length - 1 - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        double temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }


        }
    }
}
