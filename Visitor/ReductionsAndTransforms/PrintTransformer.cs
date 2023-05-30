using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal class PrintTransformer : ITransformer<string>
	{
		public string Transform(DoubleExpression de) => de.Value.ToString();

		public string Transform(AdditionExpression ae)
		{
			return $"({ae.Left.Reduce(this)} + {ae.Right.Reduce(this)})";
		}
	}
}
