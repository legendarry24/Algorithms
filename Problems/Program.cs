using Problems.GetContactByNumberSubstring;
using Problems.HashMap;
using Problems.MaximumWealth;

namespace Problems
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var problem = new RansomNoteProblem();

			var result = problem.Solve(("aac", "aabc"));
			Console.WriteLine($"[{string.Join(", ", result)}]");

			Console.WriteLine(new ValidAnagramProblem().Solve(("anagram", "nagaram")));

			Console.WriteLine(new MaximumWealthProblem().Solve(new[] { new[] { 1, 6 }, new[] { 7, 4 }, new[] { 3, 5 } }));

			string[] names = { "Kate", "John", "Alex" };
			string[] numbers = { "00000001", "911112235", "911145667" };
			Console.WriteLine(new GetContactByNumberSubstringProblem().Solve((names, numbers, "9111")));

			int[] twoSumResult = new TwoSumProblem().Solve((new[] { 3, 2, 3 }, 6));
			Console.WriteLine($"[{string.Join(", ", twoSumResult)}]");
		}
	}
}