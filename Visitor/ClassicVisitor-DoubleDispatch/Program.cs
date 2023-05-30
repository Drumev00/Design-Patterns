using ClassicVisitor_DoubleDispatch;
using System.Text;

var expr = new AdditionExpression(new DoubleExpression(1), new AdditionExpression(
	new DoubleExpression(2), new DoubleExpression(3)));
var printer = new ExpressionPrinter();
var calculator = new ExpressionCalculator();
printer.Visit(expr);
Console.WriteLine(printer);
calculator.Visit(expr);
Console.WriteLine($"{printer} = {calculator.Result}");
