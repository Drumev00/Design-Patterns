
using DynamicDecoratorComposition.Abstractions;

namespace DynamicDecoratorComposition
{
	internal class TransparentShape : IShape
	{
		private IShape _shape;
		private float _transparency;

		public TransparentShape(IShape shape, float transparency)
		{
			_shape = shape ?? throw new ArgumentNullException(nameof(shape));
			_transparency = transparency;
		}

		public string AsString()
		{
			return $"{_shape.AsString()} has {_transparency * 100.0}% transparency";
		}
	}
}
