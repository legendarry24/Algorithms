namespace HuffmanDecoding
{
	public class LeafNode : Node
	{
		public LeafNode(char symbol, string code)
			: base(code)
		{
			Symbol = symbol;
		}

		public char Symbol { get; }
	}
}