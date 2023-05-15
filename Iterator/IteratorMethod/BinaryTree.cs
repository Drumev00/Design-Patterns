namespace IteratorMethod
{
	// NOT IEnumerable -> InOrderIterator<T> has Current and MoveNext()!
	internal class BinaryTree<T>
	{
		private Node<T> _root;

		public BinaryTree(Node<T> root)
		{
			_root = root;
		}

		//public IEnumerable<Node<T>> InOrder
		//{
		//	get
		//	{
		//		// C# 7 embedding method inside a method
		//IEnumerable<Node<T>> Traverse(Node<T> current)
		//{
		//	if (current.Left != null)
		//	{
		//		foreach (var left in Traverse(current.Left))
		//		{
		//			yield return left;
		//		}
		//	}
		//	yield return current;
		//	if (current.Right != null)
		//	{
		//		foreach (var right in Traverse(current.Right))
		//		{
		//			yield return right;
		//		}
		//	}
		//}

		//		foreach (var node in Traverse(_root))
		//		{
		//			yield return node;
		//		}
		//	}
		//}


		// in case in-order is the ONLY way of traversing
		public InOrderIterator<T> GetEnumerator()
		{
			return new InOrderIterator<T>(_root);
		}
	}
}
