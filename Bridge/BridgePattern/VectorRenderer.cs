using BridgePattern.Abstractions;

namespace BridgePattern
{
	internal class VectorRenderer : IRenderer
	{
		public void RenderCircle(float radius)
		{
			Console.WriteLine($"Drawing a circle of radius: {radius}");
		}
	}
}
