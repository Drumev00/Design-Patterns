using AbstractFactory.Abstractions;

namespace AbstractFactory
{
	internal class TeaFactory : IHotDrinkFactory
	{
		public IHotDrink Prepare(int amount)
		{
			Console.WriteLine($"Put in a tea bag, boil water, pour {amount}ml and lemon.");
			return new Tea();
		}
	}
}
