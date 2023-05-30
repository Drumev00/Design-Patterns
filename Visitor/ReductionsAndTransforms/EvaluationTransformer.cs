using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal class EvaluationTransformer : ITransformer<double>
	{
		public double Transform(DoubleExpression de) => de.Value;

		public double Transform(AdditionExpression ae)
		{
			return ae.Left.Reduce(this) + ae.Right.Reduce(this);
		}
	}
}
