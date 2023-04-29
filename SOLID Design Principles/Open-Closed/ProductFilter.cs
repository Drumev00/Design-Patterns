using Open_Closed.Enums;

namespace Open_Closed
{
	internal class ProductFilter
	{
		public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
		{
			foreach (var p in products)
			{
				if (p.Size == size)
				{
					yield return p;
				}
			}
		}

		public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
		{
			foreach (var p in products)
			{
				if (p.Color == color)
				{
					yield return p;
				}
			}
		}
	}
}
