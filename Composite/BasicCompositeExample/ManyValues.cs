namespace BasicCompositeExample
{
	public class ManyValues : List<int>, IValueContainer
	{
		public int Value { get; set; }
	}
}
