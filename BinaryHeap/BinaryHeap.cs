using System;

namespace BinaryHeap
{
	public abstract class BinaryHeap
	{
		protected const int RootIndex = 0;

		private int _capacity;
		private int _size;

		protected BinaryHeap(int capacity)
		{
			Items = new int[capacity];
		}

		public int Size => _size;

		protected int[] Items { get; }

		/// <summary>
		/// Retrieves, but does not remove, the head of this heap, or throws an exception if this heap is empty.
		/// </summary>
		public int Peek()
		{
			if (_size == 0) throw new IndexOutOfRangeException();

			return Items[RootIndex];
		}

		/// <summary>
		/// Retrieves and removes the head of this heap, or throws an exception if this heap is empty.
		/// </summary>
		public int Pop()
		{
			if (_size == 0) throw new IndexOutOfRangeException();

			int root = Items[RootIndex];

			Items[RootIndex] = Items[_size - 1];
			_size--;

			SiftDown();

			return root;
		}

		public void Add(int item)
		{
			EnsureExtraCapacity();

			Items[_size++] = item;

			SiftUp();
		}

		protected abstract void SiftUp();

		protected abstract void SiftDown();

		protected int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;

		protected int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;

		protected int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

		protected bool HasLeftChild(int parentIndex) => GetLeftChildIndex(parentIndex) < _size;

		protected bool HasRightChild(int parentIndex) => GetRightChildIndex(parentIndex) < _size;

		protected bool IsRoot(int index) => index == RootIndex;

		protected void Swap(int firstIndex, int secondIndex)
		{
			int temp = Items[firstIndex];
			Items[firstIndex] = Items[secondIndex];
			Items[secondIndex] = temp;
		}

		private void EnsureExtraCapacity()
		{
			if (_size == _capacity)
			{
				Array.Copy(Items, Items, _capacity * 2);

				_capacity *= 2;
			}
		}
	}
}