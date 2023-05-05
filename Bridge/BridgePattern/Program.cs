using Autofac;
using BridgePattern;
using BridgePattern.Abstractions;

// Without DI

//IRenderer renderer = new RasterRenderer();
//IRenderer renderer = new VectorRenderer();
//var circle = new Circle(renderer, 5);

//circle.Draw();
//circle.Resize(2);
//circle.Draw();

// With DI

var builder = new ContainerBuilder();
builder.RegisterType<VectorRenderer>().As<IRenderer>();

// we want to specify the radius when we Resolve<T> the circle 
builder.Register((ctx, param) => new Circle(ctx.Resolve<IRenderer>(), param.Positional<float>(0)));

using (var container = builder.Build())
{
	var circle = container.Resolve<Circle>(new PositionalParameter(0, 5.0f));
	circle.Draw();
	circle.Resize(2.0f);
	circle.Draw();
}
