using SingletonImplementation.Abstractions;

namespace SingletonImplementation
{
	internal class ConfigurableRecordFinder
	{
		private IDatabase _database;

		public ConfigurableRecordFinder(IDatabase database)
		{
			_database = database ?? throw new ArgumentNullException(nameof(database));
		}

		public int GetTotalPopulation(IEnumerable<string> cities)
		{
			int result = 0;
			foreach (string city in cities)
			{
				result += _database.GetPopulation(city);
			}

			return result;
		}
	}
}
