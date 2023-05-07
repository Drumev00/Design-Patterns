using Autofac;
using DIDecorator;
using DIDecorator.Abstractions;

var builder = new ContainerBuilder();
builder.RegisterType<ReportingService>().Named<IReportingService>("reporting");
builder.RegisterDecorator<IReportingService>((ctx, service) => new ReportingServiceWithLogging(service), "reporting");

using (var container = builder.Build())
{
	var service = container.Resolve<IReportingService>();
	service.Report();
}
