namespace ReductionsAndTransforms.Abstractions
{
	internal interface ITransformer<out T>
	{
		T Transform(DoubleExpression de);
		T Transform(AdditionExpression ae);
	}
}
