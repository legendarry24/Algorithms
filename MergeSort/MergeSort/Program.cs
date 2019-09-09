using System;
using System.Diagnostics;

// In most cases 3rd algorithm is faster than the others
namespace MergeSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 12, 5, 13, 25, 76, 48, 3, 7, 1, 21, 19 , 11, 13, 24};
			var arr2 = new int[arr.Length];
			arr.CopyTo(arr2, 0);
			var arr3 = new int[arr.Length];
			arr.CopyTo(arr3, 0);
			var arr4 = new int[arr.Length];
			arr.CopyTo(arr4, 0);

			Console.WriteLine("initial array:");
			Console.WriteLine(string.Join(", ", arr));

			Stopwatch sw = Stopwatch.StartNew();
			MergeSort1.MergeSort(arr);
			sw.Stop();
			Console.WriteLine("\nafter sorting:");
			Console.WriteLine(string.Join(", ", arr));
			Console.WriteLine($"elapsed time: {sw.Elapsed}");

			sw.Restart();
			MergeSort2.MergeSort(arr2);
			sw.Stop();
			Console.WriteLine("\nanother sorting algorithm:");
			Console.WriteLine(string.Join(", ", arr2));
			Console.WriteLine($"Number of array inversions: {MergeSort2.Inversions}");
			Console.WriteLine($"elapsed time: {sw.Elapsed}");

			sw.Restart();
			MergeSort3.MergeSort(arr3);
			sw.Stop();
			Console.WriteLine("\none more sorting algorithm:");
			Console.WriteLine(string.Join(", ", arr3));
			Console.WriteLine($"elapsed time: {sw.Elapsed}");

			sw.Restart();
			MergeSort4.MergeSort(arr4);
			sw.Stop();
			Console.WriteLine("\nthe other sorting algorithm:");
			Console.WriteLine(string.Join(", ", arr4));
			Console.WriteLine($"elapsed time: {sw.Elapsed}");
		}
	}
}