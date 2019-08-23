using System;
using System.Collections.Generic;

namespace BinaryHeap
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

			BinaryHeap heap = new MaxHeap(n);
			var commands = new List<string>(n);

			for (int i = 0; i < n; i++)
			{
				commands.Add(Console.ReadLine());
			}

			foreach (string command in commands)
			{
				if (command.StartsWith("Insert"))
				{
					int item = int.Parse(command.Substring(command.IndexOf(' ')));

					heap.Add(item);
				}
				else if (command == "ExtractMax")
				{
					int item = heap.Pop();

					Console.WriteLine(item);
				}
			}
		}
	}
}
