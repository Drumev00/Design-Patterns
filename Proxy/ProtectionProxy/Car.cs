using ProtectionProxy.Abstractions;

namespace ProtectionProxy
{
	internal class Car : ICar
	{
		public void Drive()
		{
			Console.WriteLine("Car is being driven");
		}
	}
}
