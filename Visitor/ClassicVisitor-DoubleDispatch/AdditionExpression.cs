using System.Text;

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
	}
}
