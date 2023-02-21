namespace Problems.RansomNote
{
	public class RansomNoteProblem : IProblem<bool, (string RansomNote, string Magazine)>
	{
		public bool Solve((string RansomNote, string Magazine) input)
		{
			(string ransomNote, string magazine) = input;

			if (ransomNote.Length > magazine.Length)
			{
				return false;
			}

			var charCount = new Dictionary<char, int>();

			// Count the frequency of each character in magazine
			foreach (char c in magazine)
			{
				if (!charCount.ContainsKey(c))
				{
					charCount[c] = 0;
				}

				charCount[c]++;
			}

			// Check if ransomNote can be constructed using the characters in magazine
			foreach (char c in ransomNote)
			{
				if (!charCount.ContainsKey(c) || charCount[c] == 0)
				{
					return false;
				}

				charCount[c]--;
			}

			return true;
		}
	}
}