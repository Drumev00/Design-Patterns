namespace Dependency_Inversion.Abstractions
{
	internal interface IRelationshipBrowser
	{
		IEnumerable<Person> FindAllChildrenOf(string name);
	}
}
