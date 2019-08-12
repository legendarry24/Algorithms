namespace HuffmanCoding
{
	public class Node
	{
		public Node(int frequency)
		{
			Frequency = frequency;
		}

		public int Frequency { get; }

		public string Code { get; private set; }

		public virtual void BuildCode(string code)
		{
			Code = code;
		}
	}
}