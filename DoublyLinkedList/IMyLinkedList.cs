namespace DoublyLinkedList
{
	public interface IMyLinkedList<T> : ICollection<T>
	{
		void AddFirst(T item);

		void AddLast(T item);

		LinkedListNode<T> GetMiddleNode();

		void RemoveFirst();

		void RemoveLast();

		T[] ToArray();
	}
}