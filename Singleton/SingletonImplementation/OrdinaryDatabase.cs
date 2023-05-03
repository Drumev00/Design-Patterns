using MoreLinq;
using SingletonImplementation.Abstractions;

namespace SingletonImplementation
{
	internal class OrdinaryDatabase : IDatabase
	{
		private Dictionary<string, int> _capitals;

		public OrdinaryDatabase()
		{
			Console.WriteLine("Initializing Database...");

			_capitals = File.ReadAllLines(
				Path.Combine(
					new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName,
					"capitals.txt"))
				.Batch(2)
				.ToDictionary(
				list => list.ElementAt(0).Trim(),
				list => int.Parse(list.ElementAt(1).Trim())
				);
		}

		public int GetPopulation(string cityName)
		{
			return _capitals[cityName];
		}
	}
}
