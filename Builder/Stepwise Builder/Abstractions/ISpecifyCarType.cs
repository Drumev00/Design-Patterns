namespace Stepwise_Builder.Abstractions
{
	internal interface ISpecifyCarType
	{
		ISpecifyWheelSize OfType(CarType type);
	}
}
