using JetBrains.dotMemoryUnit;
using NUnit.Framework;

namespace RepeatingUsernames
{
	[TestFixture]
	internal class UserTests
	{
		[Test]
		public void TestUser()
		{
			var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
			var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

			var users = new List<User>();

			foreach (var firstName in firstNames)
			{
				foreach (var lastName in lastNames)
				{
					users.Add(new User($"{firstName} {lastName}"));
				}
			}

			ForceGC();

			dotMemory.Check(memory =>
			{
				Console.WriteLine(memory.SizeInBytes);
			});
		}

		[Test]
		public void TestBetterUser()
		{
			var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
			var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

			var users = new List<BetterUser>();

			foreach (var firstName in firstNames)
			{
				foreach (var lastName in lastNames)
				{
					users.Add(new BetterUser($"{firstName} {lastName}"));
				}
			}

			ForceGC();

			dotMemory.Check(memory =>
			{
				Console.WriteLine(memory.SizeInBytes);
			});
		}

		private void ForceGC()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		private string RandomString()
		{
			Random r = new Random();

			return new string(Enumerable.Range(0, 10).Select(i => (char)('a' + r.Next(26))).ToArray());
		}
	}
}
