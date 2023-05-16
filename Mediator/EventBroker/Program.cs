using Autofac;
using EventBroker;

var builder = new ContainerBuilder();
builder.RegisterType<EventBroker.EventBroker>().SingleInstance();
builder.RegisterType<Coach>();
// it wants a name in ctor
builder.Register((ctx, param) => 
	new Footballer(
		ctx.Resolve<EventBroker.EventBroker>(),
		param.Named<string>("name")));

using (var container = builder.Build())
{
	var coach = container.Resolve<Coach>();
	var john = container.Resolve<Footballer>(new NamedParameter("name", "John"));
	var chris = container.Resolve<Footballer>(new NamedParameter("name", "Chris"));

	john.Score();
	john.Score();
	john.Score(); // ignored by coach
	john.AssaultReferee();
	chris.Score();
}
