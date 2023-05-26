using DynamicStrategy;

var processor = new TextProcessor();
processor.SetOutputFormat(OutputFormat.Markdown);
processor.AppendList(new[] { "foo", "Bar", "baz" });

Console.WriteLine(processor);
processor.Clear();

processor.SetOutputFormat(OutputFormat.Html);
processor.AppendList(new[] { "foo", "Bar", "baz" });
Console.WriteLine(processor);