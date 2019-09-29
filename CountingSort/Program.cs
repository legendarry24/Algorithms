using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CountingSort
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Stopwatch sw = Stopwatch.StartNew();
			Console.WriteLine(string.Join(",", CountSort(array)));
			sw.Stop();
			Console.WriteLine($"elapsed time: {sw.Elapsed}");
		}

		static IEnumerable<int> CountSort(int[] array)
		{
			int min = array[0];
			int max = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < min) min = array[i];
				else if (array[i] > max) max = array[i];
			}

			// init array of frequencies
			var counts = new int[max - min + 1];

			// init counts for each item
			foreach (int item in array)
			{
				counts[item - min]++;
			}

			// sum of counts
			for (int i = 1; i < counts.Length; i++)
			{
				counts[i] = counts[i] + counts[i - 1];
			}

			var sorted = new int[array.Length];

			// Sort the array
			for (int i = array.Length - 1; i >= 0; i--)
			{
				// find position for item by its index in sum of counts array
				// and reduce sum of counts array for given index by 1
				int position = counts[array[i] - min]-- - 1;

				// put item in sorted collection on calculated position
				sorted[position] = array[i];
			}

			return sorted;
		}
	}
}