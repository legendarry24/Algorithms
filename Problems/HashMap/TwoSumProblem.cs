namespace Problems.HashMap
{
	public class TwoSumProblem : IProblem<int[], (int[] Nums, int Target)>
	{
		public int[] Solve((int[] Nums, int Target) input)
		{
			(int[] nums, int target) = input;

			if (nums.Length < 2) return Array.Empty<int>();

			//for (int i = 0; i < nums.Length; i++)
			//{
			//	for (int j = i + 1; j < nums.Length; j++)
			//	{
			//		if (nums[i] + nums[j] == target)
			//		{
			//			return new[] {i, j};
			//		}
			//	}
			//}

			// HashMap solution
			var numIndexMap = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int diff = target - nums[i];

				if (numIndexMap.ContainsKey(diff))
				{
					return new[] { numIndexMap[diff], i };
				}

				numIndexMap[nums[i]] = i;
			}

			return Array.Empty<int>();
		}
	}
}