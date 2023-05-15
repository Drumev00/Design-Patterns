namespace PreOrder
{
	internal class Node<T>
	{
		public T Value;
		public Node<T> Left, Right;
		public Node<T> Parent;

		public Node(T value)
		{
			Value = value;
		}

		public Node(T value, Node<T> left, Node<T> right)
		{
			Value = value;
			Left = left;
			Right = right;
		}

		public IEnumerable<T> PreOrder
		{
			get
			{
				var result = new List<Node<T>>();
				result.Add(this);
				result.AddRange(Traverse(this.Left));
				result.AddRange(Traverse(this.Right));
				return result.Select(x => x.Value);
			}
		}

		public IEnumerable<Node<T>> Traverse(Node<T> current)
		{
			yield return current;
			if (current.Left != null)
			{
				foreach (var left in Traverse(current.Left))
				{
					yield return left;
					if (current.Left == null)
					{
						foreach (var node in Traverse(current.Parent.Right))
						{
							yield return node;
						}
					}
				}
			}
			if (current.Right != null)
			{
				foreach (var right in Traverse(current.Right))
				{
					yield return right;
					if (current.Right == null)
					{
						foreach (var node in Traverse(current.Parent.Left))
						{
							yield return node;
						}
					}
				}
			}
		}
	}
}
