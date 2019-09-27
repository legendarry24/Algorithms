namespace BinaryHeap
{
	public static class HeapSort
	{
		private const int RootIndex = 0;
		private static int _heapSize;

		public static void Sort(int[] array)
		{
			BinaryHeap heap = new MinHeap(array.Length);

			foreach (int item in array)
			{
				heap.Add(item);
			}

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = heap.Pop();
			}
		}

		public static void SortWithoutUsingExtraMemory(int[] array)
		{
			_heapSize = array.Length;
			BuildMaxHeap(array);

			for (int i = array.Length - 1; i >= 0; i--)
			{
				Swap(array, RootIndex, i);
				_heapSize--;
				SiftDown(array, RootIndex);
			}
		}

		private static int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;

		private static int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;

		private static bool HasLeftChild(int parentIndex) => GetLeftChildIndex(parentIndex) < _heapSize;

		private static bool HasRightChild(int parentIndex) => GetRightChildIndex(parentIndex) < _heapSize;

		private static void BuildMaxHeap(int[] array)
		{
			for (int i = _heapSize / 2 - 1; i >= 0; i--)
			{
				SiftDown(array, i);
			}
		}

		private static void SiftDown(int[] array, int index)
		{
			while (HasLeftChild(index))
			{
				int biggerChildIndex = GetLeftChildIndex(index);

				if (HasRightChild(index) && array[GetRightChildIndex(index)] > array[GetLeftChildIndex(index)])
				{
					biggerChildIndex = GetRightChildIndex(index);
				}

				if (array[index] >= array[biggerChildIndex])
				{
					break;
				}

				Swap(array, index, biggerChildIndex);
				index = biggerChildIndex;
			}
		}

		private static void Swap(int[] array, int firstIndex, int secondIndex)
		{
			int temp = array[firstIndex];
			array[firstIndex] = array[secondIndex];
			array[secondIndex] = temp;
		}
	}
}