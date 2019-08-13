namespace HuffmanDecoding
{
	public class InternalNode : Node
	{
		public InternalNode(Node left, Node right)
			: base(left.Code.Substring(0, left.Code.Length - 1))
		{
			Left = left;
			Right = right;
		}

		public Node Left { get; }

		public Node Right { get; }
	}
}