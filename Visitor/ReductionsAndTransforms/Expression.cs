using ReductionsAndTransforms.Abstractions;

namespace ReductionsAndTransforms
{
	internal abstract class Expression
	{
		public abstract T Reduce<T>(ITransformer<T> transformer);
	}
}
