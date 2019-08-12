using System;

namespace HuffmanCoding
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input a test string:");
			string inputString = Console.ReadLine();

			var huffmanTree = new HuffmanTree();

			huffmanTree.Build(inputString);

			string encodedString = huffmanTree.Encode(inputString);
			Console.WriteLine(encodedString);

			string decodedString = huffmanTree.Decode(encodedString);
			Console.WriteLine(decodedString);
		}
	}
}