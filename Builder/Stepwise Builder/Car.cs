namespace Stepwise_Builder
{
	internal class Car
	{
		public CarType Type { get; set; }

		public int WheelSize { get; set; }

		public override string ToString()
		{
			return $"Car of type {Type} has {WheelSize} wheel size.";
		}
	}
}
