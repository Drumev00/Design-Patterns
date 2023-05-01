using AbstractFactory.Abstractions;
using System.Reflection;

namespace AbstractFactory
{
	internal class HotDrinkMachine
	{
		private List<Tuple<string, IHotDrinkFactory>> _factories;

		public HotDrinkMachine()
		{
			_factories = new();

			foreach (Type type in typeof(HotDrinkMachine).Assembly.GetTypes())
			{
				if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
				{
					_factories.Add(Tuple.Create(
						type.Name.Replace("Factory", string.Empty),
						(IHotDrinkFactory)Activator.CreateInstance(type)
						));
				}
			}
		}

		public IHotDrink MakeDrink()
		{
			Console.WriteLine("Available drinks: ");
			for (int i = 0; i < _factories.Count; i++)
			{
				var tuple = _factories[i];
				Console.WriteLine($"{i}: {tuple.Item1}");
			}

			while (true)
			{
				string s;
				if ((s = Console.ReadLine()) != null 
					&& int.TryParse(s, out var i) 
					&& i >= 0 
					&& i < _factories.Count)
				{
					Console.Write("Specify amount: ");
					s = Console.ReadLine();
					if (s != null
						&& int.TryParse(s, out int amount)
						&& amount > 0)
					{
						return _factories[i].Item2.Prepare(amount);
					}
				}

				Console.WriteLine("Incorrect input, try again!");
			}
		}
	}
}
