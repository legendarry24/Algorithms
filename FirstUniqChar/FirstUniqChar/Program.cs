namespace FirstUniqChar
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetFirstUniqChar("aabbcd")); // output: 4
		}

		private static int GetFirstUniqChar(string input)
		{
			if (input.Length == 1)
			{
				return 0;
			}

			for (int i = 0; i < input.Length; i++)
			{
				char currentChar = input[i];

				//bool matchFound = false;

				//for (int j = 0; j < input.Length; j++)
				//{
				//	if (currentChar == input[j] && i != j)
				//	{
				//		matchFound = true;
				//		break;
				//	}
				//}

				// LINQ version
				bool matchFound = input.Where((c, j) => currentChar == c && i != j).Any();

				if (!matchFound)
				{
					return i;
				}
			}

			return -1;
		}
	}
}