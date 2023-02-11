using Problems.MaximumWealth;
using Problems.RunningSum;

namespace Problems
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var problem = new RunningSumProblem();

			var result = problem.Solve(new[] { 1, 2, 3, 4 });

			Console.WriteLine($"[{string.Join(", ", result)}]");

			Console.WriteLine(new MaximumWealthProblem().Solve((new[] { new[] { 1, 6 }, new[] { 7, 4 }, new[] { 3, 5 } })));
		}
	}
}