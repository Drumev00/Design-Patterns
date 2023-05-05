using BridgePattern.Abstractions;

namespace BridgePattern
{
	internal class Circle : Shape
	{
		private float _radius;

		/* Instead of having a methods for rendering in raster or vector form
		 * we provide IRenderer for doing it. That's the bridge.
		 */
		public Circle(IRenderer renderer, float radius) : base(renderer)
		{
			_radius = radius;
		}

		public override void Draw()
		{
			renderer.RenderCircle(_radius);
		}

		public override void Resize(float factor)
		{
			_radius *= factor;
		}
	}
}
