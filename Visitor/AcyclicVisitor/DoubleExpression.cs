using AcyclicVisitor.Abstractions;

namespace AcyclicVisitor
{
	internal class DoubleExpression : Expression
	{
		public double Value { get; }

		public DoubleExpression(double value)
		{
			Value = value;
		}

		public override void Accept(IVisitor visitor)
		{
			if (visitor is IVisitor<DoubleExpression> typed)
			{
				typed.Visit(this);
			}
		}
	}
}
