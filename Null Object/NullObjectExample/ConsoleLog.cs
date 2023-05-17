using NullObjectExample.Abstractions;

namespace NullObjectExample
{
	internal class ConsoleLog : ILog
	{
		public void Info(string message)
		{
			Console.WriteLine(message);
		}

		public void Warn(string message)
		{
			Console.WriteLine("WARNING!" + message);
		}
	}
}
