namespace DoublyLinkedList
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var linkedList = new DoublyLinkedList<int>(new[] { 1, 2, 3, 4, 5, 6, 7 });

			Console.WriteLine(linkedList);

			linkedList.RemoveLast();
			linkedList.AddFirst(4);
			linkedList.Remove(3);

			foreach (int item in linkedList)
			{
				Console.WriteLine(item);
			}

			linkedList.RemoveFirst();

			Console.WriteLine(linkedList);
		}
	}
}