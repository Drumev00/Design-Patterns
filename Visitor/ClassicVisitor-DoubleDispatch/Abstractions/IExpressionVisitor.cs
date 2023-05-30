namespace ClassicVisitor_DoubleDispatch.Abstractions
{
	internal interface IExpressionVisitor
	{
		// such method is needed for every member in the hierarchy
		void Visit(DoubleExpression de);
		void Visit(AdditionExpression ae);
	}
}
