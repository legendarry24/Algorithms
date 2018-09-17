namespace MergeSort
{
    public static class MergeSort4
    {
        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                // sort left and right halves
                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);

                // merge the sorted halves
                Merge(array, start, middle, end);
            }
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            // sizes of two subarrays
            int leftSize = middle - start + 1;
            int rightSize = end - middle;

            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            // copy data to temp arrays
            for (int i = 0; i < leftSize; i++)
            {
                left[i] = array[start + i];
            }

            for (int i = 0; i < rightSize; i++)
            {
                right[i] = array[middle + 1 + i];
            }

            int leftIndex = 0;
            int rightIndex = 0;
            int arrayIndex = start;

            // merge the temp arrays
            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    array[arrayIndex] = left[leftIndex++];
                }
                else
                {
                    array[arrayIndex] = right[rightIndex++];
                }

                arrayIndex++;
            }

            // copy remaining elements
            while (leftIndex < leftSize)
            {
                array[arrayIndex++] = left[leftIndex++];
            }

            while (rightIndex < rightSize)
            {
                array[arrayIndex++] = right[rightIndex++];
            }
        }
    }
}