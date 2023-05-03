namespace SingletonImplementation
{
	internal class SingletonRecordFinder
	{
		public int GetTotalPopulation(IEnumerable<string> cities)
		{
			int result = 0;
			foreach (string city in cities)
			{
				// using the (singleton) database

				/* When testing databases we want to use a 'fake' one.
				 * Here we have hardcoded reference to it.
				 * That's the 'test problem' this pattern has.
				 */
				result += SingletonDatabase.Instance.GetPopulation(city);
			}

			return result;
		}

	}
}
