using BridgePattern.Abstractions;

namespace BridgePattern
{
	internal class RasterRenderer : IRenderer
	{
		public void RenderCircle(float radius)
		{
			Console.WriteLine($"Drawing pixels for circle of radius: {radius}");
		}
	}
}
