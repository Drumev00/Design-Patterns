namespace FluentBuilder
{
	internal class PersonInfoBuilder<SELF>
		: PersonBuilder 
		where SELF : PersonInfoBuilder<SELF>
	{	
		public PersonInfoBuilder()
		{

		}

		public SELF Called(string name)
		{
			person.Name = name;
			return (SELF) this;
		}
	}
}
