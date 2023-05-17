namespace NullObjectSingleton.Abstractions
{
	internal interface ILog
	{
		void Warn();

		public static ILog Null => NullLog.Instance;

		private sealed class NullLog : ILog
		{
			private static Lazy<NullLog> _instance = new Lazy<NullLog>(() => new NullLog());

			public static ILog Instance => _instance.Value;

			private NullLog()
			{

			}

			public void Warn()
			{

			}
		}
	}
}
