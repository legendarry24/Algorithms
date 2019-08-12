using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanCoding
{
	public class HuffmanTree
	{
		private readonly List<Node> _nodes;

		private readonly Dictionary<char, Node> _charNodes;

		private Dictionary<char, int> _characterFrequencies;

		private Node _root;

		public HuffmanTree()
		{
			_nodes = new List<Node>();
			_charNodes = new Dictionary<char, Node>();
		}

		public void Build(string inputString)
		{ 
			_characterFrequencies = (inputString ?? throw new InvalidOperationException())
				.GroupBy(c => c)
				.ToDictionary(group => group.Key, group => group.Count());

			foreach (var character in _characterFrequencies)
			{
				var leafNode = new LeafNode(character.Key, character.Value);
				_nodes.Add(leafNode);
				_charNodes.Add(character.Key, leafNode);

				Console.WriteLine($"{character.Key}: {character.Value}");
			}

			int sum = 0;
			while (_nodes.Count > 1)
			{
				// Take first two items with the min frequency
				var taken = _nodes.OrderBy(node => node.Frequency).Take(2).ToList();

				// Create a parent node by combining the frequencies
				var parentNode = new InternalNode(taken[0], taken[1]);

				_nodes.Remove(taken[0]);
				_nodes.Remove(taken[1]);
				sum += parentNode.Frequency;
				_nodes.Add(parentNode);
			}

			_root = _nodes.First();

			if (_characterFrequencies.Count == 1)
			{
				sum = inputString.Length;
			}

			Console.WriteLine($"Number of unique characters: {_characterFrequencies.Count}\n" + 
							  $"Size of the encoded string: {sum}");

			_root.BuildCode(_characterFrequencies.Count == 1 ? "0" : "");
		}

		public string Encode(string inputString)
		{
			var encoded = new StringBuilder();
			foreach (char c in inputString)
			{
				encoded.Append(_charNodes[c].Code);
			}

			return encoded.ToString();
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