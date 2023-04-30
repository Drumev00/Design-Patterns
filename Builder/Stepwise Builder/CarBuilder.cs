using Stepwise_Builder.Abstractions;

namespace Stepwise_Builder
{
	internal class CarBuilder
	{
		private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
		{
			private Car _car = new Car();
			public Car Build()
			{
				return _car;
			}

			public ISpecifyWheelSize OfType(CarType type)
			{
				_car.Type = type;
				return this;
			}

			public IBuildCar WithWheels(int size)
			{
				switch (_car.Type)
				{
					case CarType.Crossover when size < 17 || size > 20:
					case CarType.Sedan when size < 15 || size > 17:
						throw new ArgumentException($"Wrong size of wheel for {_car.Type}");
				}

				_car.WheelSize = size;
				return this;
			}
		}

		public static ISpecifyCarType Create()
		{
			return new Impl();
		}
	}
}
