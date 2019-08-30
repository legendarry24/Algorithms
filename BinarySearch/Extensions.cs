using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
	public static class Extensions
	{
		public static int BinarySearch<T>(this IEnumerable<T> source, T item, IComparer<T> comparer = null)
		{
			var array = source as T[] ?? source.ToArray();
			comparer = comparer ?? Comparer<T>.Default;

			int min = 0;
			int max = array.Length - 1;

			while (min <= max)
			{
				int mid = (min + max) / 2;

				if (item.Equals(array[mid]))
				{
					return ++mid;
				}

				if (comparer.Compare(item, array[mid]) > 0)
				{
					min = mid + 1;
				}
				else
				{
					max = mid - 1;
				}
			}

			return -1;
		}

		public static int BinarySearch(this int[] array, int item)
		{
			int min = 0;
			int max = array.Length - 1;

			while (min <= max)
			{
				int mid = (min + max) / 2;

				if (item == array[mid])
				{
					return ++mid;
				}

				if (item > array[mid])
				{
					min = mid + 1;
				}
				else
				{
					max = mid - 1;
				}
			}

			return -1;
		}
	}
}