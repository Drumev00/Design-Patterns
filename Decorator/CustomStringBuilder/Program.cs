using CustomStringBuilder;

var cb = new CodeBuilder();

cb.AppendLine("class Foo")
	.AppendLine("{")
	.AppendLine("}");

Console.WriteLine(cb);

