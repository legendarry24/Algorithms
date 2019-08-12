using System;

namespace HuffmanCoding
{
	public class LeafNode : Node
	{
		public LeafNode(char symbol, int frequency)
			: base(frequency)
		{
			Symbol = symbol;
		}

		public char Symbol { get; }

		public override void BuildCode(string code)
		{
			base.BuildCode(code);

			Console.WriteLine($"{Symbol}: {code}");
		}
	}
}