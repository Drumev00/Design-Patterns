using IntrusiveVisitor;
using System.Text;

var expr = new AdditionExpression(new DoubleExpression(1), new AdditionExpression(
	new DoubleExpression(2), new DoubleExpression(3)));
var sb = new StringBuilder();
expr.Print(sb);
Console.WriteLine(sb);
