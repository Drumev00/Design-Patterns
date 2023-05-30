using System.Text;

namespace IntrusiveVisitor
{
	internal class DoubleExpression : Expression
	{
		private double _value;

		public DoubleExpression(double value)
		{
			_value = value;
		}

		public override void Print(StringBuilder sb)
		{
			sb.Append(_value);
		}
	}
}
