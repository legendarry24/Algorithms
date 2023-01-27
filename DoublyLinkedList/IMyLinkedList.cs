namespace DoublyLinkedList
{
	public interface IMyLinkedList<T> : ICollection<T>
	{
		void AddFirst(T item);

		void AddLast(T item);

		void RemoveFirst();

		void RemoveLast();

		T[] ToArray();
	}
}