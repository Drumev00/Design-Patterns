﻿namespace PrototypeExercise
{
	internal class Line
	{
		public Point Start { get; set; }

		public Point End { get; set; }

		public Line(Point start, Point end)
		{
			Start = start;
			End = end;
		}

		public Line DeepCopy()
		{
			return new Line(Start, End);
		}

		public override string ToString()
		{
			return $"{Start}, {End}";
		}
	}
}
