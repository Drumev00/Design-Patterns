using ReductionsAndTransforms;

var expr = new AdditionExpression(
	new DoubleExpression(1),
	new DoubleExpression(2));
var transformer = new EvaluationTransformer();
var result = expr.Reduce(transformer);

var printer = new PrintTransformer();
var text = expr.Reduce(printer);
Console.WriteLine($"{text} = {result}");

var squareT = new SquareTransformer();
var newExpr = expr.Reduce(squareT);
text = newExpr.Reduce(printer);
result = newExpr.Reduce(transformer);
Console.WriteLine($"{text} = {result}");
