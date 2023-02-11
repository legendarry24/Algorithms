namespace Problems.MaximumWealth
{
	public class MaximumWealthProblem : IProblem<int, int[][]>
	{
		public int Solve(int[][] accounts)
		{
			int maxWealth = 0;
			for (int i = 0; i < accounts.Length; i++)
			{
				int sum = accounts[i].Sum();
				if (sum > maxWealth)
				{
					maxWealth = sum;
				}
			}

			return maxWealth;

			// alt solution
			// return accounts.Max(x => x.Sum());
		}
	}
}