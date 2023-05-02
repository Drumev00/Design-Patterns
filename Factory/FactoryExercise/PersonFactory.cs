namespace FactoryExercise
{
	internal class PersonFactory
	{
		private readonly List<WeakReference<Person>> _people = new List<WeakReference<Person>>();

		public Person CreatePerson(string name)
		{
			var person = new Person { Name = name, Id = _people.Count };
			_people.Add(new WeakReference<Person>(person));
			return person;
		}
	}
}
