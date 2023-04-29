namespace Liskov_Substitution
{
	internal class Rectangle
	{
		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public Rectangle()
		{

		}

		public virtual int Width { get; set; }

		public virtual int Height { get; set; }

		public override string ToString()
		{
			return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
		}
	}
}
