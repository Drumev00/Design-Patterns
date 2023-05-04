using DIAdapter.Abstractions;

namespace DIAdapter
{
	internal class SaveCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Saving a file");
		}
	}
}
