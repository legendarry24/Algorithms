using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanDecoding
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			 Sample Input 2:

			 4 14
			 a: 0
			 b: 10
			 c: 110
			 d: 111
			 01001100100111

			 where 4 - Number of unique characters (n)
				   14 - Size of the encoded string
				   a - symbol, 0 - its code
				   01001100100111 - encoded string
			*/

			string inputString = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(inputString)) return;

			int n = int.Parse(inputString.Substring(0, inputString.IndexOf(' ')));

			var characterCodes = new Dictionary<char, string>();

			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();

				if (!string.IsNullOrWhiteSpace(input))
				{
					char symbol = input.Substring(0, input.IndexOf(':')).First();
					string code = input.Substring(input.IndexOf(' ') + 1);

					characterCodes.Add(symbol, code);
				}
			}

			var huffmanTree = new HuffmanTree();

			huffmanTree.Build(characterCodes);

			string encodedString = Console.ReadLine();

			Console.WriteLine(huffmanTree.Decode(encodedString));
		}
	}
}