using StaticDecoratorComposition.Abstractions;

namespace StaticDecoratorComposition
{
	internal class Circle : Shape
	{
		private float _radius;

		public Circle() : this(0)
		{
			
		}

		public Circle(float radius)
		{
			_radius = radius;
		}

		public void Resize(float factor)
		{
			_radius *= factor;
		}

		public override string AsString()
		{
			return $"A circle with radius: {_radius}";
		}
	}
}
