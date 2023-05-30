using ClassicVisitor_DoubleDispatch.Abstractions;

namespace ClassicVisitor_DoubleDispatch
{
	internal abstract class Expression
	{
		public abstract void Accept(IExpressionVisitor visitor);
	}
}
