var builder = new HtmlBuilder.HtmlBuilder("ul");
builder.AddChild("li", "Hello, ").AddChild("li", "World!");
Console.WriteLine(builder);
