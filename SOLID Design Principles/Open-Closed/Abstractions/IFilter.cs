namespace Open_Closed.Abstractions
{
	public interface IFilter<T>
	{
		IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
	}
}
