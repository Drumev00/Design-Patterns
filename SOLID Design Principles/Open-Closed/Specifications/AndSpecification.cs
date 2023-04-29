using Open_Closed.Abstractions;

namespace Open_Closed.Specifications
{
	internal class AndSpecification<T> : ISpecification<T>
	{
		private ISpecification<T> _first, _second;

		public AndSpecification(ISpecification<T> first, ISpecification<T> second)
		{
			_first = first ?? throw new ArgumentNullException(nameof(first));
			_second = second ?? throw new ArgumentNullException(nameof(second));
		}

		public bool IsSatisfied(T entity)
		{
			return _first.IsSatisfied(entity) && _second.IsSatisfied(entity);
		}
	}
}
