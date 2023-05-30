using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal class SquareTransformer : ITransformer<Expression>
	{
		public Expression Transform(DoubleExpression de)
		{
			return new DoubleExpression(de.Value * de.Value);
		}

		public Expression Transform(AdditionExpression ae)
		{
			return new AdditionExpression(ae.Left.Reduce(this), ae.Right.Reduce(this));
		}
	}
}
