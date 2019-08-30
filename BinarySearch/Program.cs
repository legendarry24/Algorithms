using System;
using System.Collections.Generic;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = new[] { 1.1, 3.2, 5.3, 7.4, 9.5 };
			var strArray = new[] { "bar", "baz", "foo" };

			Console.WriteLine(array.BinarySearch(3.2));
			Console.WriteLine(strArray.BinarySearch("foo"));

			var source = ParseInputString(Console.ReadLine().Split(' '));
			var items = ParseInputString(Console.ReadLine().Split(' '));

			foreach (int item in items)
			{
				Console.Write($"{source.BinarySearch(item)} ");
			}
		}

		static int[] ParseInputString(IReadOnlyList<string> input)
		{
			int length = int.Parse(input[0]);
			var array = new int[length];

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = int.Parse(input[i + 1]);
			}

			return array;
		}
	}
}
