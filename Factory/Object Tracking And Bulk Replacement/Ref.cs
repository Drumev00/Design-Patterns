namespace Object_Tracking_And_Bulk_Replacement
{
	internal class Ref<T> where T : class
	{
		public T Value { get; set; }

		public Ref(T value)
		{
			Value = value;
		}
	}
}
