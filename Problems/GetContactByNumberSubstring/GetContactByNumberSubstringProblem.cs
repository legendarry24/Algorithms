namespace Problems.GetContactByNumberSubstring
{
	public class GetContactByNumberSubstringProblem : IProblem<string, (string[] contactNames, string[] contactNumbers, string contactNumberSubstring)>
	{
		public string Solve((string[] contactNames, string[] contactNumbers, string contactNumberSubstring) input)
		{
			(string[] contactNames, string[] contactNumbers, string contactNumberSubstring) = input;

			return GetContactByNumberSubstring(contactNames, contactNumbers, contactNumberSubstring);
		}

		private static string GetContactByNumberSubstring(string[] contactNames, string[] contactNumbers, string contactNumberSubstring)
		{
			const string noContact = "NO CONTACT";

			if (contactNumberSubstring.Length is < 1 or > 9)
			{
				return noContact;
			}

			var indices = new List<int>();
			for (int i = 0; i < contactNumbers.Length; i++)
			{
				if (CheckContiguousSubstring(contactNumbers[i], contactNumberSubstring))
				{
					indices.Add(i);
				}
			}

			if (indices.Count == 0)
			{
				return noContact;
			}

			if (indices.Count == 1)
			{
				return contactNames[indices.Single()];
			}

			var names = indices.Select(index => contactNames[index]).ToList();
			names.Sort();
			return names.First();
		}

		private static bool CheckContiguousSubstring(string initialString, string substring)
		{
			for (int i = 0; i <= initialString.Length - substring.Length; i++)
			{
				// Check if the substring starting at position i matches the specified substring
				if (initialString.Substring(i, substring.Length) == substring)
				{
					return true;
				}
			}

			return false;
		}
	}
}