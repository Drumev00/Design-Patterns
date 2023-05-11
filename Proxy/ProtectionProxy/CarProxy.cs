using ProtectionProxy.Abstractions;

namespace ProtectionProxy
{
	internal class CarProxy : ICar
	{
		private Driver _driver;
		private Car _car = new();

		public CarProxy(Driver driver)
		{
			_driver = driver;
		}


		public void Drive()
		{
			if (_driver.Age >= 16)
			{
				_car.Drive();
			}
			else
			{
				Console.WriteLine("Too young");
			}
		}
	}
}
