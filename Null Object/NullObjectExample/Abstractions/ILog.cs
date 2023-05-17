namespace NullObjectExample.Abstractions
{
	internal interface ILog
	{
		void Info(string message);
		void Warn(string message);
	}
}
