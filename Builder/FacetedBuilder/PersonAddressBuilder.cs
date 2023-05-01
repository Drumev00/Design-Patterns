namespace FacetedBuilder
{
	internal class PersonAddressBuilder : PersonBuilder
	{
		// might not work with a value type
		public PersonAddressBuilder(Person person)
		{
			this.person = person;
		}

		public PersonAddressBuilder At(string streetAddress)
		{
			this.person.StreetAddress = streetAddress;
			return this;
		}

		public PersonAddressBuilder WithPostcode(string postcode)
		{
			this.person.Postcode = postcode;
			return this;
		}

		public PersonAddressBuilder In(string city)
		{
			this.person.City = city;
			return this;
		}
	}
}
