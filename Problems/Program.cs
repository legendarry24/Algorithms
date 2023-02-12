using Problems.FizzBuzzJazz;
using Problems.MaximumWealth;

namespace Problems
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var problem = new FizzBuzzJazzProblem();

			var result = problem.Solve(105);

			Console.WriteLine($"[{string.Join(", ", result)}]");

			Console.WriteLine(new MaximumWealthProblem().Solve(new[] { new[] { 1, 6 }, new[] { 7, 4 }, new[] { 3, 5 } }));
		}
	}
}