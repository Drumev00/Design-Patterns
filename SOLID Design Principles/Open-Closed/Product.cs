using Open_Closed.Enums;

namespace Open_Closed
{
	internal class Product
	{
		public Product(string name, Color color, Size size)
		{
			Name = name;
			Color = color;
			Size = size;
		}

		public string Name { get; set; } = null!;
		public Color Color { get; set; }
		public Size Size { get; set; }
	}
}
