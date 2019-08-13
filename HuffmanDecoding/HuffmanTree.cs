using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanDecoding
{
	public class HuffmanTree
	{
		private readonly List<Node> _nodes;

		private Node _root;

		public HuffmanTree()
		{
			_nodes = new List<Node>();
		}

		public void Build(Dictionary<char, string> characterCodes)
		{
			foreach (var character in characterCodes)
			{
				_nodes.Add(new LeafNode(character.Key, character.Value));
			}

			while (_nodes.Count > 1)
			{
				// Take first two items with the max code length
				var taken = _nodes
					.OrderByDescending(node => node.Code.Length)
					.ThenBy(node => node.Code)
					.Take(2)
					.ToList();

				// Create a parent node with code one bit less
				var parentNode = new InternalNode(taken[0], taken[1]);

				_nodes.Remove(taken[0]);
				_nodes.Remove(taken[1]);

				_nodes.Add(parentNode);
			}

			_root = _nodes.First();
		}

		public string Decode(string encodedString)
		{
			Node current = _root;
			var decoded = new StringBuilder();

			foreach (char bit in encodedString)
			{
				if (current is InternalNode internalNode)
				{
					current = bit == '0' ? internalNode.Left : internalNode.Right;
				}

				if (current is LeafNode leafNode)
				{
					decoded.Append(leafNode.Symbol);

					current = _root;
				}
			}

			return decoded.ToString();
		}
	}
}