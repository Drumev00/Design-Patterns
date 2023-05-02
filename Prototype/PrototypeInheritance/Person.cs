using PrototypeInheritance.Abstractions;

namespace PrototypeInheritance
{
	internal class Person : IDeepCopyable<Person>
	{
		public string[] Names { get; set; }

		public Address Address { get; set; }

		public Person()
		{

		}

		public Person(string[] names, Address address)
		{
			Names = names;
			Address = address;
		}

		public override string ToString()
		{
			return $"{nameof(Names)}: {string.Join(' ', Names)}, {nameof(Address)}: {Address}";
		}

		public void CopyTo(Person target)
		{
			target.Names = (string[])Names.Clone();
			target.Address = Address.DeepCopy();
		}
	}
}
