namespace FactoryMethod
{
	internal static class PointFactory
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
}
