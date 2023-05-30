using ClassicVisitor_DoubleDispatch.Abstractions;

namespace ClassicVisitor_DoubleDispatch
{
	internal class AdditionExpression : Expression
	{
		public Expression Left { get; }
		public Expression Right { get; }


		public AdditionExpression(Expression left, Expression right)
		{
			Left = left ?? throw new ArgumentNullException(nameof(left));
			Right = right ?? throw new ArgumentNullException(nameof(right));
		}

		public override void Accept(IExpressionVisitor visitor)
		{
			/*
			 * double dispatch - allows to pass type information about whoever it is that I'm processing from
			 * this method into the actual visitor
			*/

			visitor.Visit(this);
		}
	}
}
