using DIAdapter.Abstractions;

namespace DIAdapter
{
	internal class Button
	{
		private ICommand _command;
		private string _name;

		public Button(ICommand command, string name)
		{
			_command = command ?? throw new ArgumentNullException(nameof(command));
			_name = name;
		}

		public void Click()
		{
			_command.Execute();
		}

		public void PrintMe()
		{
			Console.WriteLine($"Button called {_name}");
		}
	}
}
