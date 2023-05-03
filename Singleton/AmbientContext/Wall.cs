namespace AmbientContext
{
	internal class Wall
	{
		public Point Start { get; set; }

		public Point End { get; set; }

		public int Height { get; set; }

		public Wall(Point start, Point end)
		{
			Start = start;
			End = end;
			Height = BuildingContext.Current.WallHeight;
		}

		public override string ToString()
		{
			return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}, {nameof(Height)}: {Height}";
		}
	}
}
