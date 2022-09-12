namespace FindMissingNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// input array contains 'N' numbers between 1 and 'N+1'
			// with one number missing and no duplicates
			int[] array = { 3, 2, 4, 7, 1, 5 };

			Console.WriteLine("The missing element is " + FindMissingNumber(array));
		}

		private static int FindMissingNumber(IReadOnlyCollection<int> array)
		{
			// the range of numbers is 1 more than the size of the array
			int n = array.Count + 1;

			// the sum of the first N natural numbers
			int total = n * (n + 1) / 2;

			// calculate the sum of all the array elements
			int sum = array.Sum();

			// expected sum - actual sum
			return total - sum;
		}

		// sum of first n natural numbers
		// 1 + 2 + 3 + 4 + n
		private static int RecursiveSum(int n)
		{
			if (n is 0 or 1)
			{
				return n;
			}

			return n + RecursiveSum(n - 1);
		}
	}
}