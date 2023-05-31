using AcyclicVisitor;

var expr = new AdditionExpression(new DoubleExpression(1), new AdditionExpression(
	new DoubleExpression(2), new DoubleExpression(3)));
var printer = new ExpressionPrinter();

printer.Visit(expr);
Console.WriteLine(printer);