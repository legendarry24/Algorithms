namespace HuffmanCoding
{
	public class InternalNode : Node
	{
		public InternalNode(Node left, Node right)
			: base(left.Frequency + right.Frequency)
		{
			Left = left;
			Right = right;
		}

		public Node Left { get; }

		public Node Right { get; }

		public override void BuildCode(string code)
		{
			base.BuildCode(code);
			Left.BuildCode(code + '0');
			Right.BuildCode(code + '1');
		}
	}
}