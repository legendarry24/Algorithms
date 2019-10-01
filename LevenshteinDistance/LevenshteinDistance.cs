using static System.Math;

namespace LevenshteinDistance
{
	public static class LevenshteinDistance
	{
		public static int Calculate(string first, string second)
		{
			var distance = new int[first.Length + 1, second.Length + 1];

			for (int n = 0; n <= first.Length; n++)
			{
				for (int m = 0; m <= second.Length; m++)
				{
					if (n == 0 && m == 0) distance[n, m] = 0;
					else if (n == 0) distance[n, m] = m;
					else if (m == 0) distance[n, m] = n;
					else
					{
						int distanceToDelete = distance[n - 1, m] + 1;
						int distanceToInsert = distance[n, m - 1] + 1;
						int distanceToReplace = distance[n - 1, m - 1] + SubstitutionCost(first[n - 1], second[m - 1]);

						distance[n, m] = Min(Min(distanceToDelete, distanceToInsert), distanceToReplace);
					}
				}
			}

			return distance[first.Length, second.Length];
		}

		private static int SubstitutionCost(char first, char second)
		{
			// if characters match there is no need to perform the substitution
			return first == second ? 0 : 1;
		}
	}
}