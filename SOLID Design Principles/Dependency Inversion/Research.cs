using Dependency_Inversion.Abstractions;

namespace Dependency_Inversion
{
	// high-level
	internal class Research
	{

		// This approach exposes a private member as public

		//public Research(Relationships relationships)
		//{
		//	var relations = relationships.Relations;
		//	foreach (var relation in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
		//	{
		//		Console.WriteLine($"John has a child called {relation.Item3.Name}");
		//	}
		//}




		// Depending on abstraction
		public Research(IRelationshipBrowser browser)
		{
			foreach (var person in browser.FindAllChildrenOf("John"))
			{
				Console.WriteLine($"John has a child called {person.Name}");
			}
		}
	}
}
