namespace BinaryHeap
{
	public class MaxHeap : BinaryHeap
	{
		public MaxHeap(int capacity) : base(capacity)
		{}

		protected override void SiftUp()
		{
			int index = Size - 1;

			while (!IsRoot(index) && Items[index] > Items[GetParentIndex(index)])
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
				int biggerChildIndex = GetLeftChildIndex(index);

				if (HasRightChild(index) && Items[GetRightChildIndex(index)] > Items[GetLeftChildIndex(index)])
				{
					biggerChildIndex = GetRightChildIndex(index);
				}

				if (Items[index] >= Items[biggerChildIndex])
				{
					break;
				}

				Swap(index, biggerChildIndex);
				index = biggerChildIndex;
			}
		}
	}
}