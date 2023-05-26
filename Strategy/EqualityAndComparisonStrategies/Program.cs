using EqualityAndComparisonStrategies;

var people = new List<Person>()
{
	new Person(2, "Bryan", 21),
	new Person(204, "Aaron", 29),
	new Person(42, "John", 41),
	new Person(22, "Ron", 33),
};

Console.WriteLine("By Id (default)");
// after implementing the default strategy (comparing objects, using relational operators) - this will sort by Id
people.Sort();
foreach (var person in people)
{
	Console.WriteLine(person);
}

// sorts by name
// people.Sort((x, y) => x.Name.CompareTo(y.Name));

Console.WriteLine("By name (custom)");
// sorts by name as well
people.Sort(Person.NameComparer);
foreach (var person in people)
{
	Console.WriteLine(person);
}


