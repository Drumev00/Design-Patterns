using System.Text;

namespace ReflectiveVisitor
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
