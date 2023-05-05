namespace BridgePattern.Abstractions
{
	internal abstract class Shape
	{
		protected IRenderer renderer;

		public Shape(IRenderer renderer)
		{
			this.renderer = renderer ?? throw new ArgumentNullException(nameof(renderer));
		}

		public abstract void Draw();
		public abstract void Resize(float factor);
	}
}
