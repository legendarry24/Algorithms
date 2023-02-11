namespace Problems
{
	public interface IProblem<out TOutput, in TInput>
	{
		TOutput Solve(TInput input);
	}
}