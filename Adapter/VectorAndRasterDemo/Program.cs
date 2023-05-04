using MoreLinq;
using VectorAndRasterDemo;

class Program
{
	private static readonly List<VectorObject> _vectors = new List<VectorObject>()
		{
			new VectorRectangle(1, 1, 10, 10),
			new VectorRectangle(3, 3, 6, 6),
		};

	public static void DrawPoint(Point point)
	{
		Console.Write(".");
	}

	private static void Draw()
	{

		foreach (var vector in _vectors)
		{
			foreach (var line in vector)
			{
				var adapter = new LineToPointAdapter(line);
				adapter.ForEach(DrawPoint);
			}
		}
	}
	static void Main(string[] args)
	{
		Draw();
		Draw();
	}
}
