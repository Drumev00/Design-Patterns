using Open_Closed.Abstractions;
using Open_Closed.Enums;

namespace Open_Closed.Specifications
{
	internal class SizeSpecification : ISpecification<Product>
	{
		private Size _size;

		public SizeSpecification(Size size)
		{
			_size = size;
		}

		public bool IsSatisfied(Product entity)
		{
			return entity.Size == _size;
		}
	}
}
