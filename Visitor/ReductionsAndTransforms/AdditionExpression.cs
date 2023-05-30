using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal class AdditionExpression : Expression
	{
		public AdditionExpression(Expression left, Expression right)
		{
			Left = left;
			Right = right;
		}

		public Expression Left { get; }
		public Expression Right { get; }

		public override T Reduce<T>(ITransformer<T> transformer)
		{
			return transformer.Transform(this);
		}
	}
}
