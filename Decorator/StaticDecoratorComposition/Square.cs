using StaticDecoratorComposition.Abstractions;

namespace StaticDecoratorComposition
{
	internal class Square : Shape
	{
		private float _side;

		public Square() : this(0.0f)
		{
				
		}

		public Square(float side)
		{
			_side = side;
		}

		public override string AsString()
		{
			return $"A square with side: {_side}";
		}
	}
}
