namespace FunctionalBuilder
{
	internal sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
	{

		public PersonBuilder Called(string name) => Do(p => p.Name = name);

		// Outsourced in an abstract class



		//private readonly List<Func<Person, Person>> _actions;

		//public PersonBuilder()
		//{
		//	_actions = new List<Func<Person, Person>>();
		//}

		//public PersonBuilder Do(Action<Person> action) => AddAction(action);

		//public PersonBuilder Called(string name) => Do(p => p.Name = name);
		
		//public Person Build() => _actions.Aggregate(new Person(), (p, f) => f(p));

		//private PersonBuilder AddAction(Action<Person> action)
		//{
		//	_actions.Add(p => 
		//	{ 
		//		action(p); 
		//		return p; 
		//	});

		//	return this;
		//}
	}
}
