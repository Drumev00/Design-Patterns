using DIDecorator.Abstractions;

namespace DIDecorator
{
	internal class ReportingServiceWithLogging : IReportingService
	{
		private readonly IReportingService _decorated;

		public ReportingServiceWithLogging(IReportingService decorated)
		{
			_decorated = decorated;
		}

		public void Report()
		{
			Console.WriteLine("Commencing log...");

			_decorated.Report();

			Console.WriteLine("Ending log...");
		}
	}
}
