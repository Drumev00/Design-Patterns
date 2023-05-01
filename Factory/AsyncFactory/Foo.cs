namespace AsyncFactory
{
	internal class Foo
	{
		private Foo()
		{

		}

		public static Task<Foo> CreateAsync()
		{
			var result = new Foo();
			return result.InitAsync();
		}
		private async Task<Foo> InitAsync()
		{
			// some async work
			await Task.Delay(1000);
			return this;
		}
	}
}
