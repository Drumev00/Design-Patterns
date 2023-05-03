using SingletonImplementation.Abstractions;

namespace SingletonImplementation
{
	internal class DummyDatabase : IDatabase
	{
		public int GetPopulation(string cityName)
		{
			return new Dictionary<string, int>()
			{
				["alpha"] = 1,
				["beta"] = 2,
				["gamma"] = 3,
			}[cityName];
		}
	}
}
