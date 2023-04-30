namespace FluentBuilder
{
	internal abstract class PersonBuilder
	{
		protected Person person = new Person();

		public PersonBuilder()
		{

		}

		public Person Build()
		{
			return person;
		}
	}
}
