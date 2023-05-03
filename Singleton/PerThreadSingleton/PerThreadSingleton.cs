namespace PerThreadSingleton
{
	internal sealed class PerThreadSingleton
	{
		// creating an instance per thread to achieve thread safety
		private static ThreadLocal<PerThreadSingleton> _threadInstance = new ThreadLocal<PerThreadSingleton>(() => new PerThreadSingleton());

		private PerThreadSingleton()
		{
			Id = Thread.CurrentThread.ManagedThreadId;
		}

		public int Id { get; set; }

		public static PerThreadSingleton ThreadInstance => _threadInstance.Value;
	}
}
