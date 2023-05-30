using System.Text;

namespace ClassicVisitor_DoubleDispatch
{
	using DictType = Dictionary<Type, Action<Expression, StringBuilder>>;

	internal static class ExpressionPrinter
	{
		private static DictType actions = new DictType
		{
			[typeof(DoubleExpression)] = (ex, sb) =>
			{
				var de = (DoubleExpression)ex;
				sb.Append(de.Value);
			},
			[typeof(AdditionExpression)] = (ex, sb) =>
			{
				var ae = (AdditionExpression)ex;
				sb.Append("(");
				Print(ae.Left, sb);
				sb.Append("+");
				Print(ae.Right, sb);
				sb.Append(")");
			}
		};

		public static void Print(Expression expression, StringBuilder sb)
		{
			actions[expression.GetType()](expression, sb);
		}

	}
}
