using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BinaryHeap
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
				Sample input:
				3
				Insert 100
				Insert 25
				ExtractMax
			*/
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

			var array = new[] { 3, 1, 2, 5, 8, 4, 3, 9, 11, 6 };

			Stopwatch sw = Stopwatch.StartNew();
			HeapSort.SortWithoutUsingExtraMemory(array);
			sw.Stop();

			Console.WriteLine(string.Join(",", array));
			Console.WriteLine($"elapsed time: {sw.Elapsed}");
		}
	}
}