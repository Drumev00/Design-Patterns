using System.Collections;

namespace VectorAndRasterDemo
{
	internal class LineToPointAdapter : IEnumerable<Point>
	{
		private static int count;
		private static Dictionary<int, List<Point>> _cache = new();

		public LineToPointAdapter(Line line)
		{
			var hash = line.GetHashCode();
			if (_cache.ContainsKey(hash)) return;

			Console.WriteLine($"{++count}: Generating points for line [{line.Start.X}, {line.Start.Y}]-[{line.End.X}, {line.End.Y}]");

			var points = new List<Point>();

			int left = Math.Min(line.Start.X, line.End.X);
			int right = Math.Max(line.Start.X, line.End.X);
			int top = Math.Min(line.Start.Y, line.End.Y);
			int bottom = Math.Max(line.Start.Y, line.End.Y);
			int dx = right - left;
			int dy = line.End.Y - line.Start.Y;

			if (dx == 0)
			{
				for (int y = top; y <= bottom; ++y)
				{
					points.Add(new Point(left, y));
				}
			}
			else if (dy == 0)
			{
				for (int x = left; x <= right; ++x)
				{
					points.Add(new Point(x, top));
				}
			}

			_cache.Add(hash, points);
		}

		public IEnumerator<Point> GetEnumerator()
		{
			return _cache.Values.SelectMany(x => x).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
