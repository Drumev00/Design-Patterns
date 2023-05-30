using ClassicVisitor_DoubleDispatch.Abstractions;

namespace ClassicVisitor_DoubleDispatch
{
	internal class DoubleExpression : Expression
	{
		public double Value { get; }

		public DoubleExpression(double value)
		{
			Value = value;
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
