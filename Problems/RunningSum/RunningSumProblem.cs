namespace Problems.RunningSum
{
	public class RunningSumProblem : IProblem<int[], int[]>
	{
		public int[] Solve(int[] input)
		{
			//int[] result = new int[input.Length];

			//result[0] = input[0];
			//for (int i = 1; i < input.Length; i++)
			//{
			//	result[i] = input[i] + result[i - 1];
			//}

			//return result;

			// alt solution
			for (int i = 1; i < input.Length; i++)
			{
				input[i] += input[i - 1];
			}

			return input;
		}
	}
}