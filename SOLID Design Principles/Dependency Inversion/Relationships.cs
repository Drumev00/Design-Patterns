using Dependency_Inversion.Abstractions;

namespace Dependency_Inversion
{
	// low-level
	internal class Relationships : IRelationshipBrowser
	{
		private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

		public void AddParentAndChild(Person parent, Person child)
		{
			_relations.Add((parent, Relationship.Parent, child));
			_relations.Add((child, Relationship.Child, parent));
		}

		// Right approach because we DEPEND on ABSTRACTION (IRelationshipBrowser)
		public IEnumerable<Person> FindAllChildrenOf(string name)
		{
			return _relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent)
				.Select(x => x.Item3);
		}

		// Not a good idea
		// public List<(Person, Relationship, Person)> Relations => _relations;
	}
}
