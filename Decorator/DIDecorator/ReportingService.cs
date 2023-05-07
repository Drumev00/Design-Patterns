using DIDecorator.Abstractions;

namespace DIDecorator
{
	internal class ReportingService : IReportingService
	{
		public void Report()
		{
			Console.WriteLine("Here's your report");
		}
	}
}
