using Problems.MaximumWealth;
using Problems.RansomNote;

namespace Problems
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var problem = new RansomNoteProblem();

			var result = problem.Solve(("aac", "aabc"));

			Console.WriteLine($"[{string.Join(", ", result)}]");

			Console.WriteLine(new MaximumWealthProblem().Solve(new[] { new[] { 1, 6 }, new[] { 7, 4 }, new[] { 3, 5 } }));
		}
	}
}