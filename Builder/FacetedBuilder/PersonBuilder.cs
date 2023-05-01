namespace FacetedBuilder
{
	internal class PersonBuilder
	{
		// reference!
		protected Person person;

		public PersonBuilder()
		{
			person= new Person();
		}

		public PersonJobBuilder Works => new PersonJobBuilder(person);
		public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

		public static implicit operator Person(PersonBuilder pb)
		{
			return pb.person;
		}
	}
}
