using Autofac;
using Autofac.Features.Metadata;
using DIAdapter;
using DIAdapter.Abstractions;

var builder = new ContainerBuilder();
builder.RegisterType<SaveCommand>().As<ICommand>()
	.WithMetadata("Name", "Save");
builder.RegisterType<OpenCommand>().As<ICommand>()
	.WithMetadata("Name", "Open");

//builder.RegisterType<Button>();
//builder.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));

builder.RegisterAdapter<Meta<ICommand>, Button>(meta => new Button(meta.Value, (string)meta.Metadata["Name"]));
builder.RegisterType<Editor>();


using (var container = builder.Build())
{
	var editor = container.Resolve<Editor>();
	//editor.ClickAll();

	foreach (var btn in editor.Buttons)
	{
		btn.PrintMe();
	}
}
