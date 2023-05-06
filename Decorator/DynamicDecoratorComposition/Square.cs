
using DynamicDecoratorComposition.Abstractions;

namespace DynamicDecoratorComposition
{
	internal class Square : IShape
	{
		private float _side;

		public Square(float side)
		{
			_side = side;
		}

		public string AsString()
		{
			return $"A square with side: {_side}";
		}
	}
}
