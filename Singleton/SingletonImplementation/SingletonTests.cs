using NUnit.Framework;

namespace SingletonImplementation
{
	[TestFixture]
	public class SingletonTests
	{
		[Test]
		public void IsSingletonTest()
		{
			var db = SingletonDatabase.Instance;
			var db2 = SingletonDatabase.Instance;

			Assert.That(db, Is.SameAs(db2));
			Assert.That(SingletonDatabase.InstanceCount, Is.EqualTo(1));
		}

		[Test]
		public void SingletonTotalPopulationTest() 
		{
			var finder = new SingletonRecordFinder();
			var names = new[] { "Seoul", "Mexico City" };
			var total = finder.GetTotalPopulation(names);

			Assert.That(total, Is.EqualTo(17500000 + 17400000));
		}
	}
}
