namespace AmbientContext
{
	internal sealed class BuildingContext : IDisposable
	{
		private static Stack<BuildingContext> _stack = new Stack<BuildingContext>();
		public int WallHeight { get; set; }

		static BuildingContext()
		{
			_stack.Push(new BuildingContext(0));
		}

		public BuildingContext(int wallHeight)
		{
			WallHeight = wallHeight;
			_stack.Push(this);
		}

		public static BuildingContext Current => _stack.Peek();

		public void Dispose()
		{
			if (_stack.Count > 1)
			{
				_stack.Pop();
			}
		}
	}
}
