using System;

namespace LevenshteinDistance
{
	class Program
	{
		static void Main(string[] args)
		{
			string first = Console.ReadLine();
			string second = Console.ReadLine();

			Console.WriteLine(LevenshteinDistance.Calculate(first, second));
		}
	}
}