namespace Sorting
{
    public static class Quick
    {
        public static void SortWithQuick(double[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            SortWithQuick(array, start, pivot - 1);
            SortWithQuick(array, pivot + 1, end);
        }

        private static int Partition(double[] array, int start, int end)
        {
            double temp;
            int marker = start;//divides left and right subarrays
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }
    }
}
