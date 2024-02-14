namespace Problems.HashMap
{
	public class ValidAnagramProblem : IProblem<bool, (string S, string T)>
	{
		public bool Solve((string S, string T) input)
		{
			(string s, string t) = input;

			if (s.Length != t.Length)
			{
				return false;
			}

			var charCount = new Dictionary<char, int>();

			foreach (char c in s)
			{
				if (charCount.ContainsKey(c))
				{
					charCount[c]++;
				}
				else
				{
					charCount[c] = 1;
				}
			}

			foreach (char c in t)
			{
				if (charCount.ContainsKey(c))
				{
					charCount[c]--;
				}
				else
				{
					return false;
				}
			}

			// Check if any character has non-zero frequency after decrementing the frequency based on the characters in string t
			return charCount.Values.All(count => count == 0);
		}
	}
}