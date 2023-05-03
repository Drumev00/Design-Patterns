using MoreLinq;
using SingletonImplementation.Abstractions;

namespace SingletonImplementation
{
	internal class SingletonDatabase : IDatabase
	{
		private Dictionary<string, int> _capitals;
		private static int _instanceCount;

		// with Lazy<T> we create an instance when someone accesses the 'Instance' property
		private static Lazy<SingletonDatabase> _instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

		private SingletonDatabase()
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
			_instanceCount++;
		}

		public static int InstanceCount => _instanceCount;

		public static SingletonDatabase Instance => _instance.Value;

		public int GetPopulation(string cityName)
		{
			return _capitals[cityName];
		}
	}
}
