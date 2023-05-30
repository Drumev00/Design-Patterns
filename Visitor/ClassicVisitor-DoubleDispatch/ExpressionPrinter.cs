using ClassicVisitor_DoubleDispatch.Abstractions;
using System.Text;

namespace ClassicVisitor_DoubleDispatch
{
	internal class ExpressionPrinter : IExpressionVisitor
	{
		private StringBuilder _sb = new StringBuilder();
		public void Visit(DoubleExpression de)
		{
			_sb.Append(de.Value);
		}

		public void Visit(AdditionExpression ae)
		{
			_sb.Append("(");
			ae.Left.Accept(this);
			_sb.Append("+");
			ae.Right.Accept(this);
			_sb.Append(")");
		}

		public override string ToString()
		{
			return _sb.ToString();
		}
	}
}
