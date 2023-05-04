using DIAdapter.Abstractions;

namespace DIAdapter
{
	internal class OpenCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Opening a file");
		}
	}
}
