using System.Collections;
using System.Text;

namespace DoublyLinkedList
{
	public class DoublyLinkedList<T> : IMyLinkedList<T>
	{
		private LinkedListNode<T>? _head;

		private LinkedListNode<T>? _tail;

		public DoublyLinkedList()
		{
		}

		public DoublyLinkedList(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException(nameof(collection));
			}

			foreach (T item in collection)
			{
				AddLast(item);
			}
		}

		public int Count { get; private set; }

		public bool IsReadOnly => false;

		public void AddFirst(T item)
		{
			LinkedListNode<T> node = new LinkedListNode<T>(item);
			LinkedListNode<T>? temp = _head;

			_head = node;
			_head.Next = temp;

			// if list was empty
			if (Count == 0)
			{
				_tail = _head;
			}
			else
			{
				temp!.Previous = _head;
			}

			Count++;
		}

		public void AddLast(T item)
		{
			LinkedListNode<T> node = new LinkedListNode<T>(item);

			if (Count == 0)
			{
				_head = node;
			}
			else
			{
				_tail!.Next = node;
				node.Previous = _tail;
			}

			_tail = node;
			Count++;
		}

		public LinkedListNode<T> GetMiddleNode()
		{
			LinkedListNode<T> middle = _head!;
			LinkedListNode<T>? end = _head;

			while (end?.Next != null)
			{
				middle = middle.Next!;
				end = end.Next.Next;
			}

			// when the end node reaches the end of the list, the middle node will be in the right place
			return middle;
		}

		public void Add(T item) => AddLast(item);

		public void Clear()
		{
			_head = null;
			_tail = null;
			Count = 0;
		}

		public bool Contains(T item)
		{
			LinkedListNode<T>? current = _head;

			while (current != null)
			{
				if (current.Value != null && current.Value.Equals(item))
				{
					return true;
				}

				current = current.Next;
			}

			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			LinkedListNode<T>? current = _head;

			while (current != null)
			{
				array[arrayIndex++] = current.Value;
				current = current.Next;
			}
		}

		public bool Remove(T item)
		{
			LinkedListNode<T>? previous = null;
			LinkedListNode<T>? current = _head;

			while (current != null)
			{
				if (current.Value != null && current.Value.Equals(item))
				{
					// item isn't first
					if (previous != null)
					{
						previous.Next = current.Next;

						// item is the last
						if (current.Next == null)
						{
							_tail = previous;
						}
						else
						{
							current.Next.Previous = previous;
						}

						Count--;
					}
					else
					{
						RemoveFirst();
					}

					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}

		public void RemoveFirst()
		{
			if (Count == 0)
			{
				return;
			}

			_head = _head!.Next;
			Count--;

			if (Count == 0)
			{
				_tail = null;
			}
			else
			{
				_head!.Previous = null;
			}
		}

		public void RemoveLast()
		{
			if (Count == 0)
			{
				return;
			}

			_tail = _tail!.Previous;
			Count--;

			if (Count == 0)
			{
				_head = null;
			}
			else
			{
				_tail!.Next = null;
			}
		}

		public T[] ToArray()
		{
			var array = new T[Count];
			int index = 0;

			CopyTo(array, index);

			return array;
		}

		public IEnumerator<T> GetEnumerator()
		{
			LinkedListNode<T>? current = _head;

			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		public override string ToString()
		{
			LinkedListNode<T>? current = _head;
			var output = new StringBuilder();

			while (current != null)
			{
				output.Append(current.Next != null
					? $"[{current.Value}], "
					: $"[{current.Value}]");

				current = current.Next;
			}

			return $"{{{output}}}";
		}
	}
}