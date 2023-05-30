using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal class DoubleExpression : Expression
	{
		public DoubleExpression(double value)
		{
			Value = value;
		}

		public double Value { get; }

		public override T Reduce<T>(ITransformer<T> transformer)
		{
			return transformer.Transform(this);
		}
	}
}
