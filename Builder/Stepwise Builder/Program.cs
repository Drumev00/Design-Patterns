using Stepwise_Builder;

var car = CarBuilder.Create()	// ISpecifyCarType
	.OfType(CarType.Crossover)  // ISpecifyWheelSize
	.WithWheels(18)				// IBuildCar
	.Build();

Console.WriteLine(car);
