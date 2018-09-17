namespace MergeSort
{
    public static class MergeSort2
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

                MergeSort(array, start, middle);
                MergeSort(array, middle + 1, end);

                Merge(array, start, middle, end);
            }
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int leftIndex = start;
            int rightIndex = middle + 1;
            int[] temp = new int[end - start + 1];
            int tempIndex = 0;

            while (leftIndex <= middle && rightIndex <= end)
            {
                if (array[leftIndex] < array[rightIndex])
                {
                    temp[tempIndex] = array[leftIndex++];
                }
                else
                {
                    temp[tempIndex] = array[rightIndex++];
                }

                tempIndex++;
            }

            while (rightIndex <= end)           // if the left array is over - add elements from the right one
            {
                temp[tempIndex++] = array[rightIndex++];
            }

            while (leftIndex <= middle)         // similarly if the right array is over
            {
                temp[tempIndex++] = array[leftIndex++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                array[start + i] = temp[i];
            }
        }
    }
}