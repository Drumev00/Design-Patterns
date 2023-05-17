using Autofac;
using NullObjectExample;
using NullObjectExample.Abstractions;

var builder = new ContainerBuilder();
builder.RegisterType<BankAccount>();
builder.RegisterType<NullLog>().As<ILog>();
using (var container = builder.Build())
{
	var acc = container.Resolve<BankAccount>();
	acc.Deposit(100);
}
