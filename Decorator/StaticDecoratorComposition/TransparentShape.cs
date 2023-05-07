using StaticDecoratorComposition.Abstractions;

namespace StaticDecoratorComposition
{
	internal class TransparentShape : Shape
	{
		private Shape _shape;
		private float _transparency;

		public TransparentShape(Shape shape, float transparency)
		{
			_shape = shape ?? throw new ArgumentNullException(nameof(shape));
			_transparency = transparency;
		}

		public override string AsString()
		{
			return $"{_shape.AsString()} has {_transparency * 100.0}% transparency";
		}
	}

	internal class TransparentShape<T> : Shape
		where T : Shape, new()
	{
		private T _shape = new T();
		private float _transparency;

		public TransparentShape() : this(0.0f)
		{

		}

		public TransparentShape(float transparency)
		{
			_transparency = transparency;
		}

		public override string AsString()
		{
			return $"{_shape.AsString()} has: {_transparency * 100.0f}% transparency";
		}
	}
}
