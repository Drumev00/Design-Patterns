namespace Prototype
{
	public class Person
	{
		public string[] Names { get; set; }

		public Address Address { get; set; }

		public Person(string[] names, Address address)
		{
			Names = names ?? throw new ArgumentNullException(nameof(names));
			Address = address ?? throw new ArgumentNullException(nameof(address));
		}

		public Person()
		{

		}

		// copy constructor
		public Person(Person other)
		{
			Names = other.Names;
			Address = new Address(other.Address);
		}

		public override string ToString()
		{
			return $"{nameof(Names)}: {string.Join(' ', Names)}, {nameof(Address)}: {Address}";
		}

		// not good if hierarchy is too big
		//public Person DeepCopy()
		//{
		//	return new Person(Names, Address.DeepCopy());
		//}
	}
}
