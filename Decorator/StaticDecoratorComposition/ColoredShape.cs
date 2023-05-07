using StaticDecoratorComposition.Abstractions;

namespace StaticDecoratorComposition
{
	internal class ColoredShape : Shape
	{
		private Shape _shape;
		private string _color;

		public ColoredShape(Shape shape, string color)
		{
			_shape = shape ?? throw new ArgumentNullException(nameof(shape));
			_color = color ?? throw new ArgumentNullException(nameof(color));
		}

		public override string AsString()
		{
			return $"{_shape.AsString()} has the color {_color}";
		}
	}

	internal class ColoredShape<T> : Shape
	where T : Shape, new()
	{
		private T _shape = new T();
		private string _color;

		public ColoredShape() : this("black")
		{
			
		}

		public ColoredShape(string color)
		{
			_color = color ?? throw new ArgumentNullException(nameof(color));
		}

		public override string AsString()
		{
			return $"{_shape.AsString()} has the color {_color}";
		}
	}
}
