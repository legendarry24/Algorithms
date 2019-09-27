namespace BinaryHeap
{
	public class MinHeap : BinaryHeap
	{
		public MinHeap(int capacity) : base(capacity)
		{}

		protected override void SiftUp()
		{
			int index = Size - 1;

			while (!IsRoot(index) && Items[index] < Items[GetParentIndex(index)])
			{
				Swap(index, GetParentIndex(index));

				index = GetParentIndex(index);
			}
		}

		protected override void SiftDown()
		{
			int index = RootIndex;

			while (HasLeftChild(index))
			{
				int smallerChildIndex = GetLeftChildIndex(index);

				if (HasRightChild(index) && Items[GetRightChildIndex(index)] < Items[GetLeftChildIndex(index)])
				{
					smallerChildIndex = GetRightChildIndex(index);
				}

				if (Items[index] < Items[smallerChildIndex])
				{
					break;
				}

				Swap(index, smallerChildIndex);
				index = smallerChildIndex;
			}
		}
	}
}