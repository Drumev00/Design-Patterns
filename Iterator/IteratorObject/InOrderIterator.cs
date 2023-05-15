namespace IteratorObject
{
	internal class InOrderIterator<T>
	{
		private readonly Node<T> _root;
		private bool _yieldedStart;
		public Node<T> Current { get; set; }

		public InOrderIterator(Node<T> root)
		{
			_root = root;
			Current = root;
			while (Current.Left != null)
			{
				Current = Current.Left;
			}
			//		1 -> root
			//	   / \
			//	  2   3
			//	  ^ Current
		}

		public bool MoveNext()
		{
			if (!_yieldedStart)
			{
				_yieldedStart = true;
				return true;
			}
			if (Current.Right != null)
			{
				Current = Current.Right;
				while (Current.Left != null)
				{
					Current = Current.Left;
				}

				return true;
			}
			else
			{
				var parent = Current.Parent;
				while (parent != null && Current == parent.Right)
				{
					Current = parent;
					parent = parent.Parent;
				}

				Current = parent;
				return Current != null;
			}
		}

		public void Reset()
		{
			Current = _root;
			_yieldedStart = false;
		}
	}
}
