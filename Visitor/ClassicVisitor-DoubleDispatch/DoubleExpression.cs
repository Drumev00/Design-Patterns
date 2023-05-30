using System.Text;

namespace ClassicVisitor_DoubleDispatch
{
	internal class DoubleExpression : Expression
	{
		public double Value { get; }

		public DoubleExpression(double value)
		{
			Value = value;
		}

	}
}
