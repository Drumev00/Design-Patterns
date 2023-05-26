using StaticStrategy;

var processor = new TextProcessor<MarkdownListStrategy>();
processor.AppendList(new[] { "foo", "Bar", "baz" });
Console.WriteLine(processor);

var processor2 = new TextProcessor<HtmlListStrategy>();

processor2.AppendList(new[] { "foo", "Bar", "baz" });
Console.WriteLine(processor2);