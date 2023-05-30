using System.Text;

namespace IntrusiveVisitor
{
	internal class AdditionExpression : Expression
	{
		private Expression _left, _right;

		public AdditionExpression(Expression left, Expression right)
		{
			_left = left ?? throw new ArgumentNullException(nameof(left));
			_right = right ?? throw new ArgumentNullException(nameof(right));
		}


		public override void Print(StringBuilder sb)
		{
			sb.Append("(");
			_left.Print(sb);
			sb.Append("+");
			_right.Print(sb);
			sb.Append(")");
		}
	}
}
