using System;

namespace Generic_class_Stack
{
	internal class Stack<T>
	{
		private readonly T[] _array;

		private int _index = 0;

		public Stack(int size)
		{
			_array = new T[size];
		}

		public void Push(T item)
		{
			_array[_index++] = item;
		}

		public T Pop()
		{
			return _array[--_index];
		}

		public T Get(int k)
		{
			return _array[k];
		}

		public void Show()
		{
			for (int i = 0; i < _index; i++)
			{
				Console.WriteLine(_array[i]);
			}
		}
	}
}