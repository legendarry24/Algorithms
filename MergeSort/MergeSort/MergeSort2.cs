namespace MergeSort
{
	public static class MergeSort2
	{
		public static int Inversions { get; private set; } = 0;

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
				if (array[leftIndex] > array[rightIndex])
				{
					temp[tempIndex] = array[rightIndex++];

					#region Additional task: Number of array inversions

					CalculateNumberOfInversions(leftIndex, middle + 1);

					#endregion
				}
				else
				{
					temp[tempIndex] = array[leftIndex++];
				}

				tempIndex++;
			}

			while (rightIndex <= end)	// if the left array is over => add elements from the right one
			{
				temp[tempIndex++] = array[rightIndex++];
			}

			while (leftIndex <= middle)	// similarly if the right array is over
			{
				temp[tempIndex++] = array[leftIndex++];
			}

			for (int i = 0; i < temp.Length; i++)
			{
				array[start + i] = temp[i];
			}
		}

		/// <summary>
		/// Increases the number of inversions by the number of remaining elements + 1 (current element)
		/// </summary>
		/// <param name="currentLeftIndex">Index of current element from left array</param>
		/// <param name="leftLength">Length of the left array</param>
		private static void CalculateNumberOfInversions(int currentLeftIndex, int leftLength)
		{
			Inversions += leftLength - currentLeftIndex;
		}
	}
}