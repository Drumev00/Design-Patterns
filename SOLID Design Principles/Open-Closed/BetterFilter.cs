using Open_Closed.Abstractions;

namespace Open_Closed
{
	internal class BetterFilter : IFilter<Product>
	{
		public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
		{
			foreach (var i in items)
			{
				if (specification.IsSatisfied(i))
				{
					yield return i;
				}
			}
		}
	}
}
