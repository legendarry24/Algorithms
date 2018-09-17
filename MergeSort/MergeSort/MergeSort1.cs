using System;

namespace MergeSort
{
    public static class MergeSort1
    {
        public static void MergeSort(int[] items)
        { 
            if (items.Length <= 1) return;

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);

            // recursive division of an array

            MergeSort(left);
            MergeSort(right);

            Merge(items, left, right);
        }

        private static void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int arrayIndex = 0;

            while (arrayIndex < items.Length)
            {
                if (leftIndex >= left.Length)           // if the left array is over - add items from the right one
                {
                    items[arrayIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)    // similarly if the right array is over
                {
                    items[arrayIndex] = left[leftIndex++];
                }
                else if (left[leftIndex] < right[rightIndex])
                {
                    items[arrayIndex] = left[leftIndex++];
                }
                else
                {
                    items[arrayIndex] = right[rightIndex++];
                }

                arrayIndex++;
            }
        }
    }
}