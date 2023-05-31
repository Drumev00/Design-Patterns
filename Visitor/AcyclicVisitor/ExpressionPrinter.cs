using AcyclicVisitor.Abstractions;
using System.Text;

namespace AcyclicVisitor
{
	internal class ExpressionPrinter : IVisitor,
		IVisitor<Expression>,
		IVisitor<DoubleExpression>,
		IVisitor<AdditionExpression>
	{
		private StringBuilder _sb = new();

		public void Visit(AdditionExpression visitable)
		{
			_sb.Append("(");
			visitable.Left.Accept(this);
			_sb.Append("+");
			visitable.Right.Accept(this);
			_sb.Append(")");
		}

		public void Visit(DoubleExpression visitable)
		{
			_sb.Append(visitable.Value);
		}

		public void Visit(Expression visitable)
		{
		}

		public override string ToString()
		{
			return _sb.ToString();
		}
	}
}
