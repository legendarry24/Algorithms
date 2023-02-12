namespace Problems.FizzBuzzJazz
{
	public class FizzBuzzJazzProblem : IProblem<IList<string>, int>
	{
		private readonly Dictionary<int, string> _mappings = new Dictionary<int, string>
		{
			{ 3, "Fizz" },
			{ 5, "Buzz" },
			{ 7, "Jazz" }
		};

		public IList<string> Solve(int n)
		{
			var output = new List<string>();

			for (int i = 1; i <= n; i++)
			{
				string currentAnswer = "";

				foreach (int divisor in _mappings.Keys)
				{
					// if the number is divisible by the key
					if (i % divisor == 0)
					{
						// concatenate the corresponding string mapping to current answer string for current number
						currentAnswer += _mappings[divisor];
					}
				}

				// the number is not divisible by all keys
				if (string.IsNullOrWhiteSpace(currentAnswer))
				{
					currentAnswer += i.ToString();
				}

				output.Add(currentAnswer);
			}

			return output;
		}
	}
}