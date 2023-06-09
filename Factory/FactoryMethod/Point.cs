﻿namespace FactoryMethod
{
	internal class Point
	{
		internal static class Factory
		{
			// factory methods
			public static Point NewCartesianPoint(double x, double y)
			{
				return new Point(x, y);
			}

			public static Point NewPolarPoint(double rho, double theta)
			{
				return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
			}
		}


		private double x, y;
		private Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		//public static Point Origin => new Point(0,0);

		//// Singleton field
		//public static Point Origin2 = new Point(0,0);

		public override string ToString()
		{
			return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
		}
	}
}
