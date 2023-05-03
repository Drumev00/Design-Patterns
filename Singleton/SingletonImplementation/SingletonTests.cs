using Autofac;
using NUnit.Framework;
using SingletonImplementation.Abstractions;

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

		// solving the 'test issue' with singleton design pattern with a simulation of a database
		[Test]
		public void ConfigurableTotalPopulationTest()
		{
			var finder = new ConfigurableRecordFinder(new DummyDatabase());

			var names = new[] { "alpha", "gamma" };
			var total = finder.GetTotalPopulation(names);

			Assert.That(total, Is.EqualTo(4));
		}

		// using DI to solve the issue
		[Test]
		public void DIPopulationTest()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
			builder.RegisterType<ConfigurableRecordFinder>();

			using (var container = builder.Build())
			{
				var finder = container.Resolve<ConfigurableRecordFinder>();
			}
		}
	}
}
