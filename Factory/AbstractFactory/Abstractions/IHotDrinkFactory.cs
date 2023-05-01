namespace AbstractFactory.Abstractions
{
	internal interface IHotDrinkFactory
	{
		IHotDrink Prepare(int amount);
	}
}
