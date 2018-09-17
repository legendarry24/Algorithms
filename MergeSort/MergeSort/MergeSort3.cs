using System;

namespace MergeSort
{
    public static class MergeSort3
    {
        public static void MergeSort(int[] array)
        {
            int[] result = MergeSort(array, 0, array.Length);
            Array.Copy(result, array, result.Length);
        }

        private static int[] MergeSort(int[] array, int start, int end)
        {
            // Step 1 - Split
            if (end - start < 2)
                return new [] { array[start] };

            int middle = start + (end - start) / 2;
            int[] left = MergeSort(array, start, middle);
            int[] right = MergeSort(array, middle, end);

            // Step 2 - MergeSort and Merge
            int[] result = new int[left.Length + right.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int index = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result[index] = left[leftIndex++];
                }
                else
                {
                    result[index] = right[rightIndex++];
                }

                index++;
            }

            // copy remaining elements
            while (leftIndex < left.Length)
                result[index++] = left[leftIndex++];

            while (rightIndex < right.Length)
                result[index++] = right[rightIndex++];

            return result;
        }
    }
}